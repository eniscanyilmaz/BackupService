using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BackupProject
{
    partial class BackupService : ServiceBase
    {
        public BackupService()
        {
            InitializeComponent();
        }
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
        protected override void OnStart(string[] args)
        {
            
        }

        protected override void OnStop()
        {
            
        }
    }
}
