using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.WebSockets;
using System.Net.Sockets;


namespace GOOGLESOFT
{
    public partial class SearchResultControl : UserControl
    {
        private string thumbNailurl;
        private string title;
        private string description;
        private string publishedAt;
        private string channelid;
        private string videoid;
        private string kind;
        private HttpClientHandler HCH;
        
        public SearchResultControl(VideoJson info)
        {
            InitializeComponent();
            this.Thumbnail.Load(info.ThumbnailURL);
            this.Title.Text = info.title;
            this.Description.Text = info.description;
            thumbNailurl = info.ThumbnailURL;
            title = info.title;
            description = info.description;
            publishedAt = info.publishedAt;
            channelid = info.publishedChannel;
            videoid = info.vidioid;
            kind = info.kind;
            if(!kind.Contains("video"))
            {
                this.Mp3DownloadButton.Visible = false;
                this.mp4DownloadButton.Visible = false;
            }
            HCH = new HttpClientHandler();
            if( HCH.SupportsAutomaticDecompression )
            {
                HCH.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }
            HCH.UseCookies = false;
        }

        private async void mp4DownloadButton_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/get_video_info?video_id=XCp_X6_1R4w&el=embedded&eurl=https://youtube.googleapis.com/v/XCp_X6_1R4w&hl=en
            string videoID = this.videoid;
            string eurl = $"https://youtube.googleapis.com/v/{videoID}";
            eurl = WebUtility.UrlEncode(eurl);
            string url = $"https://www.youtube.com/get_video_info?video_id={videoID}&el=embedded&eurl={eurl}&hl=en";//웹스트림
            MessageBox.Show(url);
            this.intersource.Text = url;
            //Form navi = new GoogleLoginForm(new Uri(url));
            //string r = httpWebGET(url, url);
            //MessageBox.Show(r);
            WebClient wc = new WebClient();
            //Task InterFile = wc.DownloadFileTaskAsync(new Uri(url), @".\imsi");
            //InterFile.Start();         
            bool en = true;
            var client = new HttpClient(HCH, true);
            using (var r = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
            {
                //MessageBox.Show("IN USING");
                if (en)
                {
                    //MessageBox.Show("IN ensurence!");
                    r.EnsureSuccessStatusCode();
                }
                var res = await r.Content.ReadAsStringAsync().ConfigureAwait(false);
                MessageBox.Show(res);
            }


            /*FileStream FS = new FileStream(@".\imsi" , FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(FS);
            string res = await sr.ReadToEndAsync();
            MessageBox.Show(res);
            FS.Close();
            sr.Close();
            wc.Dispose();
            File.Delete(@"..\imsi.txt");*/
        }

        public void download_complete(object sender, EventArgs e)
        {
            MessageBox.Show("Download Complete!!");
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
            return resResult;
        }
    }
}
