using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace GOOGLESOFT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoogleStorageButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.GoogleStorageButton.Height;
            this.SidePanel.Top = this.GoogleStorageButton.Top;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.HomeButton.Height;
            this.SidePanel.Top = this.HomeButton.Top;
        }

        private void youtubeAPIButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.youtubeAPIButton.Height;
            this.SidePanel.Top = this.youtubeAPIButton.Top;
        }

        private void GoogleDriveButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.GoogleDriveButton.Height;
            this.SidePanel.Top = this.GoogleDriveButton.Top;
        }

        private void GmailButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.GmailButton.Height;
            this.SidePanel.Top = this.GmailButton.Top;
        }

        private void GoogleComputeButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.GoogleComputeButton.Height;
            this.SidePanel.Top = this.GoogleComputeButton.Top;
        }

        private void GoogleSheetButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.GoogleSheetButton.Height;
            this.SidePanel.Top = this.GoogleSheetButton.Top;
        }

        private void TwitchTVButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.TwitchTVButton.Height;
            this.SidePanel.Top = this.TwitchTVButton.Top;
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginBoxID_TextChanged(object sender, EventArgs e)
        {
            using (var Stream = new FileStream("GoogleLoginCookie.json", FileMode.Open, FileAccess.Write))
            {
                
            }

        }

        private void LoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GoogleLoginButton_Click(object sender, EventArgs e)
        {
            var GoogleToken = new GoogleLogin(this.LoginBoxID.ToString(), this.LoginBoxPassword.ToString());
            GoogleToken.SetLoginCredencial().Start();
            
        }
    }
}
