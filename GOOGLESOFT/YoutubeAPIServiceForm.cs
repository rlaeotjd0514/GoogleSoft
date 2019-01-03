using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;


namespace GOOGLESOFT
{
    public partial class YoutubeAPIServiceForm : Form
    {
        private AuthResponse UserAccessToken;
        public YoutubeAPIServiceForm(AuthResponse userattoken)
        {
            this.UserAccessToken = userattoken;
            InitializeComponent();
        }

        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string Keyword = this.KeyWord.Text;
            string requri = String.Format("https://www.googleapis.com/youtube/v3/search?part=snippet&q={0}&key={1}", Keyword, "AIzaSyDBDHd7KZ3hkzARnkrxAFHZzw6vDMLX72Q");
            MessageBox.Show($"{requri}");
            var res = httpWebGET(requri, null);
            MessageBox.Show($"{res}");
        }
        public string httpWebGET(string url, string Referer)
        {
            Uri uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Referer = Referer;
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; Trident/6.0)";
            request.ContentType = "application/x-www-form-urlencoded";
            request.KeepAlive = true;
            request.AllowAutoRedirect = false;

            var response = (HttpWebResponse)request.GetResponse();
            var readerPost = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8, true);   // Encoding.GetEncoding("EUC-KR")
            var resResult = readerPost.ReadToEnd();
            readerPost.Close();
            response.Close();
            return resResult;
        }

        private void YoutubeAPIServiceForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
