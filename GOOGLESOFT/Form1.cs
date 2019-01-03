using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

using Google.Apis.YouTube;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;



namespace GOOGLESOFT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private AuthResponse AuthUserAccessToken;
        private string YoutubeAPIKEY;

        public AuthResponse AAT
        {
            get
            {
                return this.AuthUserAccessToken;
            }
            set
            {
                this.AuthUserAccessToken = value;
            }
        }


        private void youtubeAPIButton_Click(object sender, EventArgs e)
        {
            this.SidePanel.Height = this.youtubeAPIButton.Height;
            this.SidePanel.Top = this.youtubeAPIButton.Top;
            var YoutubeForm = new YoutubeAPIServiceForm(this.AAT);
            YoutubeForm.ShowDialog();
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

        private async void GoogleLoginButton_Click(object sender, EventArgs e)
        {
            //var GoogleToken = new GoogleLogin(this.LoginBoxID.Text.ToString(), this.LoginBoxPassword.Text.ToString());
            var GoogleToken = new GoogleLogin();
            var GoogleCred = await GoogleToken.SetLoginCredencial();
            var req = new YouTubeService(GoogleCred);   //GoogleCred는 BaseClientService.Initializer타입

            string API = req.ApiKey.ToString();
            this.ApiLabel.Text = API;
        }

        private void InnerViewButton_Click(object sender, EventArgs e)
        {
            if (this.GoogleInnerViewPanel.Visible == false)
            {
                //this.GoogleInnerViewPanel.Location = this.LoginPanel.Location;
                Point InnerViewPostion = this.LoginPanel.Location;
                InnerViewPostion.Y += this.LoginPanel.Height;
                this.GoogleInnerViewPanel.Location = InnerViewPostion;
                this.GoogleInnerViewPanel.Visible = true;
            }
            else
            {
                this.GoogleInnerViewPanel.Visible = false;
            }
        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            string ID = this.LoginBoxID.Text;
            string Ps = this.LoginBoxPassword.Text;

            var LoginForm = new GoogleLoginForm(AuthResponse.GetAutenticationURI("554669990764-3rae9jmrbn2g31pq12vsqfimptfcfag7.apps.googleusercontent.com", ""));
            LoginForm.AuthEvent += new GoogleLoginForm.authdelegate(RecvAuthCode);
            LoginForm.Show();
        }

        private void RecvAuthCode(AuthResponse RecvCode)
        {
            this.AAT = RecvCode;
            MessageBox.Show($"Main Form got the Code : {AuthUserAccessToken.Access_token}");
        }
    }
}