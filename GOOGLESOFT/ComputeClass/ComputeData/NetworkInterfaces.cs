using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data = Google.Apis.Compute.v1.Data;
using System.Windows.Forms;

namespace GOOGLESOFT.ComputeClass.ComuteData
{
    class Network //단일 인스턴스에 들어가는 네트워크 자원 단위
    {
        private Data.NetworkInterface Ni;
        Network(string name, string InternalIP = null, string ExternalIP = null)
        {
            var AC = new Data.AccessConfig();
            if(ExternalIP != null)
            {
                try
                {
                    AC.NatIP = ExternalIP;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());                    
                }                              
            }
            List<Data.AccessConfig> accesslist = new List<Data.AccessConfig>();
            accesslist.Add(AC);
            Ni.AccessConfigs = accesslist;
            if (InternalIP != null)
            {
                try
                {
                    Ni.NetworkIP = InternalIP;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            Ni.Name = name;
        }
    }
}
