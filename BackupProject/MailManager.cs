using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace BackupProject.Forms
{
    public class MailManager
    {
        string senderMail = "empty";
        List<string> mailAdresses = new List<string>(ConfigurationManager.AppSettings["mailAdresses"].Split(new char[] { ';' }));

        int fileCount = 0;
        string message ="";
        private TextBox mailadress;
        private int filesCount;
        private TextBox message1;

        public MailManager(TextBox mailadress, int filesCount, TextBox message1)
        {
            this.mailadress = mailadress;
            this.filesCount = filesCount;
            this.message1 = message1;
        }
       public  void MailSend()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(senderMail);
                foreach(string mailadress in mailAdresses)
                {
                    mail.To.Add(mailadress);
                }
                mail.Subject = $"{fileCount} Files uploaded to server!";
                mail.Body = message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["MailSender"],ConfigurationManager.AppSettings["MailSenderPassword"]);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                System.Windows.Forms.MessageBox.Show("Mail Sended!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Mail not sended but files are uploaded. Exception:{ex.Message}");
            }
        }
    }
}
