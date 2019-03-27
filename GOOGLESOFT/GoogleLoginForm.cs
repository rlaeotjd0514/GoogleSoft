using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Web;
using System.Runtime;


namespace GOOGLESOFT
{
    public partial class GoogleLoginForm : Form
    {
        public delegate void authdelegate(AuthResponse AuthCode);
        public event authdelegate AuthEvent;

        private AuthResponse AuthToken;

        public GoogleLoginForm(Uri LoginUri)
        {
            InitializeComponent();
            this.LoginBrowser.Navigate(LoginUri); // 이 폼에서 나오는 코드는 access_code
            //if ( this.LoginBrowser.DocumentText == ""
        }


        

        private void GoogleLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //string Body = ((WebBrowser)sender).DocumentText;
            //MessageBox.Show($"{Body}");
            string Mytitle = ((WebBrowser)sender).DocumentTitle.ToLower();
            string ind = Mytitle.IndexOf("success code=").ToString();
            //MessageBox.Show($"{ind}");
            if (Mytitle.IndexOf("success code=") > -1)
            {
                string AuthCode = LoginBrowser.DocumentTitle.Replace("Success code=", "");
                // 여기부터 수정하십쇼 [2018 12 29 23:57]
                string webText = ((WebBrowser)sender).DocumentText;
                int start = webText.IndexOf("code=") + 5;
                int end = webText.IndexOf(@"&");

                //start = webText.IndexOf(AuthCode, start);
                //int end = webText.IndexOf('"', start);
                string authCode = webText.Substring(start, end - start);
                /*
                if ( authCode == null  || authCode == "")
                {
                    authCode = "null";
                }*/
                //MessageBox.Show($"authCode : {authCode}");
                //Exchange the code for Access token and refreshtoken.
                var access = AuthResponse.Exchange(authCode, 
                    "554669990764-3rae9jmrbn2g31pq12vsqfimptfcfag7.apps.googleusercontent.com",
                    "k6QB-O_X71vatJwtDBe_9uKv",
                    "urn:ietf:wg:oauth:2.0:oob");
                //MessageBox.Show($"AccessToken = {access.Access_token}");
                this.AuthToken = access;
                this.Close();
            }
        }

        private void GoogleLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AuthEvent(AuthToken);
            MessageBox.Show("Token Sended!");
        }
    }
}
