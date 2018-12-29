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
            
            string Mytitle = ((WebBrowser)sender).DocumentTitle.ToLower();
            MessageBox.Show($"{Mytitle}");
            string ind = Mytitle.IndexOf("success code=").ToString();
            MessageBox.Show($"{ind}");
            if (Mytitle.IndexOf("success code=") > -1)
            {
                //LoginBrowser.Visible = false;

                // searching the body for our code
                string AuthCode = LoginBrowser.DocumentTitle.Replace("Success code=", "");
                MessageBox.Show($"{AuthCode}");  // 여기부터 수정하십쇼 [2018 12 29 23:57]
                string webText = ((WebBrowser)sender).DocumentText;
                int start = webText.IndexOf("id=\"code\"");
                start = webText.IndexOf(AuthCode, start);
                int end = webText.IndexOf('"', start);
                string authCode = webText.Substring(start, end - start);
                
                //Exchange the code for Access token and refreshtoken.
                var access = AuthResponse.Exchange(authCode, 
                    "554669990764-3rae9jmrbn2g31pq12vsqfimptfcfag7.apps.googleusercontent.com",
                    "k6QB-O_X71vatJwtDBe_9uKv",
                    "urn:ietf:wg:oauth:2.0:oob");
                MessageBox.Show($"{access.refresh_token}");
            }
            else
            {
                MessageBox.Show("in else");
            }
        }
    }
}
