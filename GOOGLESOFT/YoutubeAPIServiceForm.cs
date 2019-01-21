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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;



namespace GOOGLESOFT
{
    public partial class YoutubeAPIServiceForm : Form
    {
        private AuthResponse UserAccessToken;
        private List<SearchResultControl> ResultControlList = new List<SearchResultControl>();
        List<VideoJson> VideoArray = new List<VideoJson>();
        delegate void D(int i, JToken J);

        public YoutubeAPIServiceForm(AuthResponse userattoken)
        {
            this.UserAccessToken = userattoken;
            InitializeComponent();
            WebQueryAsync.WorkerReportsProgress = true;
            WebQueryAsync.WorkerSupportsCancellation = true;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.WebQueryAsync.RunWorkerAsync();
            /*string Keyword = this.KeyWord.Text;
            string requri = String.Format("https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=50&q={0}&key={1}", Keyword, "AIzaSyDBDHd7KZ3hkzARnkrxAFHZzw6vDMLX72Q");
            MessageBox.Show($"{requri}");
            var res = await Task<JObject>.Run( () => httpWebGET(requri, null));
            MessageBox.Show($"{res.ToString()}");
            
            JArray VA = JArray.Parse(res["items"].ToString());
            MessageBox.Show($"{VA.Count}");

            int count = 0;
            foreach (var item in VA )
            {
                Thread T = new Thread( () => SetResultBox(count, item) );
                D a = new D( SetResultBox );
                try
                {
                    a.Invoke(count, item);
                    count++;
                }
                catch ( Exception )
                {
                    a.Invoke(count, item);
                    count++;
                }
            } // 무조건 automouse = true 입니다.
            this.Text = "";
            //this.SearchResult.Controls.AddRange(ResultControlList.ToArray());*/
        }
        private async void WebQueryAsync_DoWork(object sender, DoWorkEventArgs e)
        {
            string Keyword = this.KeyWord.Text;
            string requri = String.Format("https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=10&q={0}&key={1}", Keyword, "AIzaSyDBDHd7KZ3hkzARnkrxAFHZzw6vDMLX72Q");
            MessageBox.Show($"{requri}");
            var res = await Task<JObject>.Run(() => httpWebGET(requri, null));
            MessageBox.Show($"{res.ToString()}");

            JArray VA = JArray.Parse(res["items"].ToString());
            MessageBox.Show($"{VA.Count}");

            int count = 0;
            foreach (var item in VA)
            {
                Thread T = new Thread( delegate () { SetResultBox(count, item); });
                D a = new D(SetResultBox);
                T.Start();
                count++;
                /*try
                {
                    a.Invoke(count, item);
                    count++;
                }
                catch (Exception)
                {
                    a.Invoke(count, item);
                    count++;
                }*/
            }
        }

        private void WebQueryAsync_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var src in ResultControlList)
            {
                this.SearchResult.Controls.Add(src);
            }
        }
        private void SetResultBox(int RunCount, JToken item)
        {
            VideoJson videoinfo = new VideoJson();
            videoinfo.title = item["snippet"]["title"].ToString();
            videoinfo.description = item["snippet"]["description"].ToString();
            videoinfo.ThumbnailURL = item["snippet"]["thumbnails"]["default"]["url"].ToString();
            VideoArray.Add(videoinfo);
            SearchResultControl SRC = new SearchResultControl(videoinfo);
            SRC.Location = new Point(0, RunCount * 110);
            //this.SearchResult.Controls.Add(SRC);
            ResultControlList.Add(SRC);
        }
        public JObject httpWebGET(string url, string Referer)
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
            JObject jsresult = JObject.Parse(resResult);
            readerPost.Close();
            response.Close();
            return jsresult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//close button

        private void KeyWord_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }


        private void KeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show($"{Convert.ToInt32(e.KeyChar)}");
            if (e.KeyChar == 13)
            {
                e.KeyChar = Convert.ToChar(0);
                MessageBox.Show("Enter!");
                SearchButton_Click(sender, EventArgs.Empty);
                /*string Keyword = this.KeyWord.Text;
                string requri = String.Format("https://www.googleapis.com/youtube/v3/search?part=snippet&q={0}&key={1}", Keyword, "AIzaSyDBDHd7KZ3hkzARnkrxAFHZzw6vDMLX72Q");
                MessageBox.Show($"{requri}");
                var res = httpWebGET(requri, null);
                MessageBox.Show($"{res.ToString()}");*/
            }
        }

        bool MD;
        int MPx, MPy;

        private void YoutubFormMover_MouseDown(object sender, MouseEventArgs e)
        {
            MD = true;
            MPx = e.X;
            MPy = e.Y;
        }

        private void YoutubFormMover_MouseMove(object sender, MouseEventArgs e)
        {
            if (MD == true)
            {
                this.SetDesktopLocation(MousePosition.X - MPx, MousePosition.Y - MPy);
            }
        }

        private void YoutubFormMover_MouseUp(object sender, MouseEventArgs e)
        {
            MD = false;
        }
    }
    public class VideoJson
    {
        public string title { get; set; }
        public string description { get; set; }
        public string ThumbnailURL { get; set; }
    }
}
