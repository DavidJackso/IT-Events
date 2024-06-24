using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Security;

namespace Service
{
    internal class Server
    {
        static string pathtokey = "data/server/key.pub";
        static FileStream stream = new FileStream(pathtokey, FileMode.Open, FileAccess.Read);
        static PrivateKeyFile key = new PrivateKeyFile(pathtokey);
        static ConnectionInfo connectionInfo = new ConnectionInfo("51.250.17.119","joseph",new PrivateKeyAuthenticationMethod("joseph", key));
        static string[] bases = new string[]{"data/bases/users.json", "data/bases/usertoevents.json", "data/bases/events.json" };
        public Server()
        {

        }
        public void DownloadBases()
        {
            try
            {
                var client = new SftpClient(connectionInfo);
                client.Connect();
                foreach (var item in bases)
                {
                    Stream fileStream = File.Create(item);
                    client.DownloadFile(item.Split('/')[2], fileStream);
                    fileStream.Close();
                }
                client.Disconnect();
            }
            catch (Renci.SshNet.Common.SshAuthenticationException)
            {
                MessageBox.Show("Не удаеться получить доступ к серверу.Проверьте подключение к интернету и обратитесь в службу тех поддержки");
            }
        }
        public void UpdateBases()
        {
            try
            {            
                var client = new SftpClient(connectionInfo);
                client.Connect();
                foreach (var item in bases)
                {
                    Stream fileStream = File.OpenRead(item);
                    client.UploadFile(fileStream, item.Split('/')[2]);
                    fileStream.Close();
                }
                client.Disconnect(); 
            }
            catch (Renci.SshNet.Common.SshAuthenticationException)
            {
                MessageBox.Show("Не удаеться получить доступ к серверу.Проверьте подключение к интернету и обратитесь в службу тех поддержки");
            }
        }
    }
}
