using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.IO;

namespace GOOGLESOFT
{
    internal class SSHclient
    {
        SshClient client;

        public SSHclient(string ip, int port, string user, string pw)
        {
            try
            {
                PrivateKeyFile pkf = new PrivateKeyFile(@"C:\Users\lotte_test\Desktop\개인 프로젝트\GoogleSoft\Compute Service\Login Keys\스타2\aa", pw);
                PrivateKeyAuthenticationMethod pam = new PrivateKeyAuthenticationMethod(user, pkf);
                ConnectionInfo connInfo = new ConnectionInfo(ip, port, user, pam);

                client = new SshClient(connInfo);
                client.Connect();

                if (client.IsConnected)
                {
                    MessageBox.Show("연결 성공");
                }
                else
                {
                    MessageBox.Show("연결 실패");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string RunCommand(string CmdText)
        {
            var ret = client.RunCommand(CmdText);
            return ret.Execute();
        }        
    }
}
