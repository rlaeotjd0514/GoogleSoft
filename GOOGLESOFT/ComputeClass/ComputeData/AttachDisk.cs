using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data = Google.Apis.Compute.v1.Data;

namespace GOOGLESOFT.ComputeClass.ComuteData
{
    /// <summary>
    /// AttachDisk 타입만 정의함 http로 들어가는 insert메서드는 추후에 재정의
    /// </summary>
    internal class GoogleDisk
    {
        private Data.AttachedDisk AttachDiskInstance;

        public Data.AttachedDisk GetDisk()
        {
            return AttachDiskInstance;
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DiskName"></param>
        /// <param name="Zone"></param>
        /// <param name="ProjectID"></param>
        /// <param name="DiskType">pd-standard, pd-ssd, local-ssd</param>
        /// <param name="Size">Disk Size</param>
        /// <param name="Boot">init as boot disk</param>
        /// <param name="AutoDelete">delete disk when attached instance is deleted</param>
        GoogleDisk(string DiskName, string Zone, string ProjectID, string DiskType, long? Size, bool? Boot = false, bool? AutoDelete = true)            
        {
            string Type = "projects/" + ProjectID + "/zones/" + Zone + "/disktypes/" + DiskType;
            var diskinit = new Data.AttachedDiskInitializeParams();
            diskinit.DiskName = DiskName;
            diskinit.DiskSizeGb = Size;
            diskinit.DiskType = Type;
            AttachDiskInstance.InitializeParams = diskinit;
            AttachDiskInstance.Boot = Boot;
            AttachDiskInstance.AutoDelete = AutoDelete;
        }                        
    }
}
