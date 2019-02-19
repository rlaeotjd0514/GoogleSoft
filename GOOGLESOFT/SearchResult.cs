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
        private static HttpClientHandler HCH;                        
        
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
                this.Mp3DownloadButton.Dispose();
                this.mp4DownloadButton.Dispose();
            }

            DownloadProgressBar.Maximum = 99;
            DownloadProgressBar.Minimum = 0;
            DownloadProgressBar.Step = 1;
            DownloadProgressBar.Value = 0;
        }

        public event EventHandler JsonRes;
        JObject result_Json;

        private async void mp4DownloadButton_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/get_video_info?video_id=XCp_X6_1R4w&el=embedded&eurl=https://youtube.googleapis.com/v/XCp_X6_1R4w&hl=en
            string videoID = this.videoid;
            string eurl = $"https://youtube.googleapis.com/v/{videoID}";
            eurl = WebUtility.UrlEncode(eurl);
            string url = $"https://www.youtube.com/get_video_info?video_id={videoID}&el=embedded&eurl={eurl}&hl=en/get_video_info";//웹스트림
            this.intersource.Text = url;
            
            //Task InterFile = wc.DownloadFileTaskAsync(new Uri(url), @".\imsi");
            //InterFile.Start();
            var client = httpClient.GetSingleClient();
            var resu = await client.GetStringHttp(url);
            //MessageBox.Show(resu);// 비디오의 정보를 가져오는 중
            result_Json = ParsePlayerResponse(resu);
            //MessageBox.Show($"{result_Json.ToString()}");// 비디오를 다운로드하는중

            JsonRes(result_Json, EventArgs.Empty);//유튜브 폼에 받아온 제이선 파일 표시

            string video_url = result_Json["streamingData"]["formats"][2]["url"].ToString();            

            //MessageBox.Show(video_url);

            using (var wc = new WebClient())
            {
                string filename = DateTime.Now.ToString(@"yyyyMMddhhmmss") + ".mp4";
                wc.DownloadFileCompleted += download_complete;
                wc.DownloadProgressChanged += download_progress_step;
                wc.DownloadFileAsync(new Uri(video_url), filename);
            }            
            /*using (var r = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
            {
                MessageBox.Show("IN USING");
                if (en)
                {
                    //MessageBox.Show("IN ensurence!");
                    r.EnsureSuccessStatusCode();
                }
                MessageBox.Show(url);
                string res = await r.Content.ReadAsStringAsync().ConfigureAwait(false);
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

        void download_complete(object sender, EventArgs e)
        {
            MessageBox.Show("Download Complete!!");
        }

        void download_progress_step(object sender, EventArgs e)
        {
            this.DownloadProgressBar.PerformStep();
        }

        public JObject ParsePlayerResponse(string ServerRes)
        {
            int start = ServerRes.IndexOf(@"player_response=");
            start = start + "player_response=".Length;
            int end = ServerRes.IndexOf(@"}&");
            string parse = ServerRes.Substring(start, end - start + 1/*&는 제이슨에 포함 안댐*/);
            //MessageBox.Show(parse);
            var ret = JObject.Parse(parse);
            return ret;
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

        private async void Mp3DownloadButton_Click(object sender, EventArgs e)
        {
            string videoID = this.videoid;
            string eurl = $"https://youtube.googleapis.com/v/{videoID}";
            eurl = WebUtility.UrlEncode(eurl);
            string url = $"https://www.youtube.com/get_video_info?video_id={videoID}&el=embedded&eurl={eurl}&hl=en/get_video_info";//웹스트림
            this.intersource.Text = url;

            //Task InterFile = wc.DownloadFileTaskAsync(new Uri(url), @".\imsi");
            //InterFile.Start();
            var client = httpClient.GetSingleClient();
            var resu = await client.GetStringHttp(url);
            //MessageBox.Show(resu);// 비디오의 정보를 가져오는 중
            result_Json = ParsePlayerResponse(resu);
            //MessageBox.Show($"{result_Json.ToString()}");// 비디오를 다운로드하는중
            JsonRes(result_Json, EventArgs.Empty);//유튜브 폼에 받아온 제이선 파일 표시

            JToken[] adlist = result_Json["streamingData"]["adaptiveFormats"].ToArray<JToken>();
            url = "";
            foreach(var it in adlist)
            {
                if (it["mimeType"].ToString().Contains("audio/mp4")) url = it["url"].ToString();
            }

            if(url == "")
            {
                MessageBox.Show("There is no audio link in this video");
                return;
            }

            using (WebClient wc = new WebClient())
            {
                this.DownloadProgressBar.Value = 0;
                wc.DownloadFileCompleted += download_complete;
                wc.DownloadProgressChanged += download_progress_step;
                wc.DownloadFileAsync(new Uri(url), DateTime.Now.ToString("yyyymmddhhmmss") + ".mp3");                                
            }
        }
    }
}
