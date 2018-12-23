using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Services;
using Google.Apis.Auth.OAuth2;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.YouTube;
using Google.Apis.Util.Store;
using DotNetOpenAuth.OAuth;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GOOGLESOFT
{
    class GoogleLogin
    {
        string LoginID;
        string LoginPw;
        YouTubeService YS;
        public GoogleLogin(string ID, string Pw)
        {
            LoginID = ID;
            LoginPw = Pw;
            using (var GoogleCred = new StreamWriter("../../Resources/Logs.txt"))
            {
                GoogleCred.WriteLine("Log>>>ID:{0}:Pw:{1}", LoginID, LoginPw);

            }
        }
        public GoogleLogin()
        {
            string Cred = File.ReadAllText("C:\\Users\\31337\\source\\repos\\GOOGLESOFT\\GOOGLESOFT\\Resources\\GoogleLoginCookie.json");
            JObject CredJ = JObject.Parse(Cred);
            JToken ID = CredJ["web"]["client_id"];
            JToken Pw = CredJ["web"]["client_secret"];
            LoginID = ID.ToString();
            LoginPw = Pw.ToString();
            //컴파일시 파일 경로 주의!
            using (var GoogleCred = new StreamWriter("../../Resources/Logs.txt")) {
                GoogleCred.WriteLine("Log>>>ID:{0}:Pw:{1}", LoginID, LoginPw); 
            }
        }
        
        public async Task<YouTubeService> SetLoginCredencial()
        {
            UserCredential cred;
            using (var stream = new FileStream("../../Resources/GoogleLoginCookie.json", FileMode.Open, FileAccess.Read))
            {
                cred = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.Youtube },
                    "user", CancellationToken.None);
            }

            /*
            var UserInfo = await GoogleWebAuthorizationBroker.AuthorizeAsync
                (new ClientSecrets { ClientId = LoginID, ClientSecret = LoginPw },
                    new[] { YouTubeService.Scope.Youtube },
                    "MakiseKurisu",
                    CancellationToken.None);
            */
            var GoogleYoutube = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = cred,
                ApplicationName = "YOUTUBE GUI",
                //ApiKey = "AIzaSyDBDHd7KZ3hkzARnkrxAFHZzw6vDMLX72Q",
                
            });
            if(GoogleYoutube == null)
            {
                throw new Exception("youtube API Login Failed!!\n");
            }
            return GoogleYoutube;
        }
    }
}
