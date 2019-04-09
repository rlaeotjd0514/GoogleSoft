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

        private AuthResponse AuthToken;
        private string ProjectID;
        private string ProJectName;

        private ComputeService MonoComputeServicenInstance;


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
            //컴퓨트 서비스 인스턴스 초기화
            var Cred = GetCredential();
            if(Cred == null)
            {
                MessageBox.Show("크레덴셜 생성자 초기화가 실패했습니다.");
                return;
            }
            ComputeService CS = new ComputeService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "GoogleSoft",
            });            
            MonoComputeServicenInstance = CS;
        }

        public GoogleCredential GetCredential()
        {
            try
            {
                GoogleCredential credential = GoogleCredential.FromAccessToken(AuthToken.Access_token);
                //GoogleCredential credential = Task.Run(() => GoogleCredential.GetApplicationDefaultAsync()).Result;
                if (credential.IsCreateScopedRequired)
                {
                    credential = credential.CreateScoped("https://www.googleapis.com/auth/cloud-platform");
                }
                return credential;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }            
        }

        public string RemoveInstance(string InstanceName, string zone)
        {
            try
            {
                var msg = MonoComputeServicenInstance.Instances.Delete(ProjectID, zone, InstanceName);
                var res = msg.Execute();
                return res.Status;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        internal string GetInstanceStatus(string InstanceName, string zone = "asia-east1-a")
        {
            try
            {
                var req = MonoComputeServicenInstance.Instances.Get(ProjectID, zone, InstanceName);
                var res = req.Execute();               
                return res.Status;
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        internal string RuninstanceByName(string InstanceName, string zone = "asia-east1-a")
        {
            var req = MonoComputeServicenInstance.Instances.Start(ProjectID, zone, InstanceName);
            var res = req.Execute();
            return res.Status;
        }

        internal string GetConnectionData(string InstanceName, string ConnType, string zone = "asia-east1-a")//ssh
        {
            var req = MonoComputeServicenInstance.Instances.Get(ProjectID, zone, InstanceName);
            var res = req.Execute();
            return "";
        }

        internal Dictionary<string, string> GetInstanceMetaData(string InstanceName, string ConnType, string zone = "asia-east1-a")
        {
            var req = MonoComputeServicenInstance.Instances.Get(ProjectID, zone, InstanceName);
            var res = req.Execute();
            var metdic = res.Metadata.Items.Where(s => s.Key == "fizz10wkddls");
            return new Dictionary<string, string>();
        }

        internal List<string> GetInstnaceList(string Filter)
        {
            List<string> result = new List<string>();
            return new List<string>();
        }

        /// <summary>
        /// 내부 테스트용 함수, 제일 간단한 옵션으로 인스턴스 하나 생성함.
        /// </summary>
        /// <param name="InstanceName">생성할 인스턴스 이름</param>
        /// <param name="zone">region string</param>
        /// <param name="MachineType">Machine Type string</param>
        /// <param name="Image">Client OS</param>
        /// <param name="ImageProject"></param>
        /// <param name="SizeGb">Size of Disk</param>
        /// <returns>Cient Operation ID</returns>
        /// MachineType의 n1-standard-N 의 N이 cpu 갯수
        internal string TestCreateInstance(string InstanceName = "kimjjang-31", string zone = "asia-east1-a", string MachineType = "zones/asia-east1-a/machineTypes/n1-standard-1", string Image = "debian-9", string ImageProject = "debian-cloud", long? SizeGb = 10)
        {                        
            Data.Instance BodyContent = new Data.Instance();                       
            var networkaccessconfig = new Data.AccessConfig();//외부주소/NAT설정
            networkaccessconfig.Name = "Default Network Setting";
            networkaccessconfig.Type = "ONE_TO_ONE_NAT";            
            var networkconfiglist = new List<Data.AccessConfig>();            
            networkconfiglist.Add(networkaccessconfig);            
            var networkinterface = new Data.NetworkInterface();//내부 주소 설정
            networkinterface.AccessConfigs = networkconfiglist;
            var networkinterfacelist = new List<Data.NetworkInterface>();
            networkinterfacelist.Add(networkinterface);            

            var disk = new Data.AttachedDisk();
            //disk.Source = new Data.AttachedDiskInitializeParams().SourceImage = $"https://www.googleapis.com/compute/v1/projects/{ProjectID}/zones/{zone}/disks/{InstanceName}";
            var diskinit = new Data.AttachedDiskInitializeParams();

            var Tags = new Data.Tags();
            var settings = new List<string>();//생성시에 사용되는 옵션들은 대부분 태그에서 생성 / 조절
            settings.Add("http-server");
            settings.Add("https-server");
            Tags.Items = settings;
            
            diskinit.DiskName = "imsi";
            diskinit.DiskSizeGb = SizeGb;
            diskinit.DiskType = $"https://www.googleapis.com/compute/v1/projects/{ProjectID}/zones/{zone}/diskTypes/pd-standard";            
            diskinit.SourceImage = "projects/debian-cloud/global/images/family/debian-9";
            disk.InitializeParams = diskinit;                        
            disk.Boot = true;
            disk.AutoDelete = true;//인스턴스 삭제할 때 디스크도 같이 삭제
            var disklist = new List<Data.AttachedDisk>();            
            disklist.Add(disk);         
            BodyContent.Name = InstanceName;
            BodyContent.NetworkInterfaces = networkinterfacelist;//1대1 NAT -> 내/외부 설정은 AccessConfig에서 따로 설정
            BodyContent.MachineType = MachineType;//"zones/asia-east1-a/machineTypes/n1-standard-1"
            BodyContent.MinCpuPlatform = "Intel Ivy Bridge";
            BodyContent.Disks = disklist;
            BodyContent.Tags = Tags;
            
            var req = MonoComputeServicenInstance.Instances.Insert(BodyContent, this.ProjectID, zone);
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
                else
                {
                    MessageBox.Show("알 수 없는 에러가 발생했습니다.");
                    MessageBox.Show(e.ToString());
                }
                return null;
            }            
            //디스크를 생성하면 디스크 인스턴스는 따로 만들어지고 따로 삭제 안해주면 중복된 이름 예외 발생함.            
            //string url = $"https://www.googleapis.com/compute/v1/projects/[PROJECT_ID]/zones/[ZONE]/instances";
            //string body = "{\"name\":\"[INSTANCE_NAME]\",\"machineType\":\"machineTypes/[MACHINE_TYPE]\",\"networkInterfaces\":[{\"accessConfigs\":[{\"type\":\"ONE_TO_ONE_NAT\",\"name\":\"ExternalNAT\"}],\"network\":\"global/networks/default\"}],\"disks\":[{\"autoDelete\":\"true\",\"boot\":\"true\",\"type\":\"PERSISTENT\",\"initializeParams\":{\"sourceImage\":\"projects/[IMAGE_PROJECT]/global/images/family/[IMAGE]\"}},{\"initializeParams\":{\"diskSizeGb\":\"[SIZE_GB]\",\"sourceImage\":\"[IMAGE]\"},{\"initializeParams\":{\"diskSizeGb\":\"[SIZE_GB]\"}}]";            
        }                          
    }
}