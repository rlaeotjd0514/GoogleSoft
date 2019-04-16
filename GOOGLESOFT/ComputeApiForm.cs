using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOOGLESOFT.ComputeClass;
using Google.Apis.Compute.v1;
using System.IO;
using System.Security.Cryptography;

namespace GOOGLESOFT
{
    public partial class ComputeApiForm : Form
    {
        private AuthResponse ATT;
        private ComputeServiceInstance MonoComputeService;

        public ComputeApiForm(AuthResponse ATT)
        {
            InitializeComponent();
            this.ATT = ATT;
            MonoComputeService = GetServiceInstance();
        }

        internal ComputeServiceInstance GetServiceInstance()
        {
            if (MonoComputeService != null)
            {
                return MonoComputeService;
            }
            else
            {
                return new ComputeServiceInstance("youtube-gui-225813", "YOUTUBE GUI", ATT);
            }
        }        

        private void ComputeApiForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateInstanceButton_Click(object sender, EventArgs e)
        {             
            MonoComputeService.TestCreateInstance("kimjjang-31", "asia-east1-a", "zones/asia-east1-a/machineTypes/n1-standard-1", "debian-9", "debian-cloud", 100);
            //테스트용 인스턴스 Name
        }

        private void RunInstanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MonoComputeService.RuninstanceByName("kimjjang-31"));
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestStatusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MonoComputeService.GetInstanceStatus("kimjjang-31"));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var ret = MonoComputeService.RemoveInstance("kimjjang-31", "asia-east1-a");
            MessageBox.Show(ret);
        }    
        #region 폼 이동
        bool MD;
        int MPx;
        int MPy;

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD == true)
            {
                this.SetDesktopLocation(MousePosition.X - MPx, MousePosition.Y - MPy);
            }
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            MD = false;
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            MD = true;
            MPx = e.X;
            MPy = e.Y;
        }
        #endregion

        private void GetSSHbutton_Click(object sender, EventArgs e)
        {
            //Stream pks = File.Open(@"C:\Users\lotte_test\Desktop\개인 프로젝트\GoogleSoft\Compute Service\Login Keys\스타2\PrivateKey.ppk", FileMode.Open);
            //MessageBox.Show(pks.ReadByte().ToString());
            SSHclient sSHclient = new SSHclient("35.234.49.93", 22, "fizz10wkddls", "tmxk210Rnfwoa");
            MessageBox.Show(sSHclient.RunCommand("pwd"));            
        }
    }
}
