using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace GOOGLESOFT
{
    public static class httpClient
    {
        private static HttpClient SingleClient;

        public static HttpClient GetSingleClient()
        {
            if (SingleClient != null)
            {
                MessageBox.Show("Using prev client");
                return SingleClient;
            }
            MessageBox.Show("CREATE NEW CLIENT");
            var HCH = new HttpClientHandler();
            if (HCH.SupportsAutomaticDecompression)
            {
                HCH.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }
            HCH.UseCookies = false;

            var client = new HttpClient(HCH, true);
            SingleClient = client;
            return SingleClient;
        }

        public static async Task<string> GetStringHttp(this HttpClient hc, string url)
        {
            using (var res = await hc.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
            {
                //MessageBox.Show($"{res.StatusCode}");
                //MessageBox.Show($"{res.Content.Headers.ContentType.ToString()}");                
                res.EnsureSuccessStatusCode();
                var result = await res.Content.ReadAsStringAsync();
                result = WebUtility.UrlDecode(result);
                return result;
            }
        }
    }
}
