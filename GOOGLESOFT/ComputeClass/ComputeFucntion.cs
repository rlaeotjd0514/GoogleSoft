using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings;
using System.Threading.Tasks;
using Google.Apis.Compute.v1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Web;
using System.Data;
using Data = Google.Apis.Compute.v1.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.Windows.Forms;
using GOOGLESOFT;

namespace GOOGLESOFT.ComputeClass
{
    internal class ComputeServiceInstance
    {
        /// <summary>
        /// Creator of Compute Service
        /// </summary>
        /// <param name="PID">Project ID(String)</param>
        /// <param name="PName">Project Name(String)</param>
        public ComputeServiceInstance(string PID, string PName, AuthResponse ATT)
        {
            this.ProjectID = PID;
            this.ProJectName = PName;
            this.AuthToken = ATT;
        }

        private AuthResponse AuthToken;
        private string ProjectID;
        private string ProJectName;

        internal string TestCreateInstance(string InstanceName, string zone, string MachineType, string Image, string ImageProject, long? SizeGb)
        {
            ComputeService CS = new ComputeService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "GoogleSoft",
            });
            Data.Instance BodyContent = new Data.Instance();

            var networkaccessconfig = new Data.AccessConfig();
            networkaccessconfig.Name = "Default Network Setting";
            networkaccessconfig.Type = "ONE_TO_ONE_NAT";
            var networkconfiglist = new List<Data.AccessConfig>();
            networkconfiglist.Add(networkaccessconfig);
            var networkinterface = new Data.NetworkInterface();
            networkinterface.AccessConfigs = networkconfiglist;
            var networkinterfacelist = new List<Data.NetworkInterface>();
            networkinterfacelist.Add(networkinterface);

            var disk = new Data.AttachedDisk();
            //disk.Source = new Data.AttachedDiskInitializeParams().SourceImage = $"https://www.googleapis.com/compute/v1/projects/{ProjectID}/zones/{zone}/disks/{InstanceName}";
            var diskinit = new Data.AttachedDiskInitializeParams();            
                        
            diskinit.DiskName = "imsi";
            diskinit.DiskSizeGb = SizeGb;
            diskinit.DiskType = $"https://www.googleapis.com/compute/v1/projects/{ProjectID}/zones/{zone}/diskTypes/pd-standard";            
            diskinit.SourceImage = "projects/debian-cloud/global/images/family/debian-9";
            disk.InitializeParams = diskinit;
            disk.Boot = true;
            var disklist = new List<Data.AttachedDisk>();
            disklist.Add(disk);
    
            BodyContent.Name = InstanceName;
            BodyContent.NetworkInterfaces = networkinterfacelist;           
            BodyContent.MachineType = MachineType;
            BodyContent.Disks = disklist;
            var req = CS.Instances.Insert(BodyContent, this.ProjectID, zone);
            try
            {
                var ret = req.Execute();
                if (ret.Error != null)
                {
                    MessageBox.Show("Error : " + ret.Error.ToString());
                }
                if (ret.Warnings != null)
                {
                    MessageBox.Show("Warning : " + ret.Warnings.ToString());
                }
                return ret.ClientOperationId;
            }
            catch (Exception e)
            {
                if(e.ToString().Contains("403"))
                {
                    MessageBox.Show("구글 컴퓨트에 접근할 권한이 있는지 확인하십시오. 결제 방법이나 약관에 동의했는지 확인해주십시오");                    
                }
                return null;
            }            
            //디스크를 생성하면 디스크 인스턴스는 따로 만들어지고 따로 삭제 안해주면 중복된 이름 예외 발생함.
            
            //string url = $"https://www.googleapis.com/compute/v1/projects/[PROJECT_ID]/zones/[ZONE]/instances";
            //string body = "{\"name\":\"[INSTANCE_NAME]\",\"machineType\":\"machineTypes/[MACHINE_TYPE]\",\"networkInterfaces\":[{\"accessConfigs\":[{\"type\":\"ONE_TO_ONE_NAT\",\"name\":\"ExternalNAT\"}],\"network\":\"global/networks/default\"}],\"disks\":[{\"autoDelete\":\"true\",\"boot\":\"true\",\"type\":\"PERSISTENT\",\"initializeParams\":{\"sourceImage\":\"projects/[IMAGE_PROJECT]/global/images/family/[IMAGE]\"}},{\"initializeParams\":{\"diskSizeGb\":\"[SIZE_GB]\",\"sourceImage\":\"[IMAGE]\"},{\"initializeParams\":{\"diskSizeGb\":\"[SIZE_GB]\"}}]";            
        }

        public GoogleCredential GetCredential()
        {            
            GoogleCredential credential = GoogleCredential.FromAccessToken(AuthToken.Access_token);
            //GoogleCredential credential = Task.Run(() => GoogleCredential.GetApplicationDefaultAsync()).Result;
            if (credential.IsCreateScopedRequired)
            {
                credential = credential.CreateScoped("https://www.googleapis.com/auth/cloud-platform");
            }
            return credential;
        }
    }
}






