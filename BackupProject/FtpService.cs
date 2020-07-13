using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupProject
{
    public class FtpService
    {
        public struct FTPproperties
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public FTPproperties ftpProperties;
        public void InitFtpSettings()
        {
            ftpProperties = new FTPproperties()
            {
                Username = ConfigurationManager.AppSettings["Username"],
                Server = ConfigurationManager.AppSettings["Server"],
                Password = ConfigurationManager.AppSettings["Password"]
            };
        }
    }
}
