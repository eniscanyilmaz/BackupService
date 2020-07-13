using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupProject
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }
        FtpService ftpService = new FtpService();
        private void BackupForm_Load(object sender, EventArgs e)
        {
            ftpService.InitFtpSettings();
            cancelUpload.Visible = false;
        }
        List<FileInfo> files = new List<FileInfo>();
        private void selectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog() { Multiselect = true, InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) })
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    foreach (string item in opf.FileNames)
                    {
                   
                        if (files.Find(x => x.Name == Path.GetFileName(item)) == null)
                        {
                            files.Add(new FileInfo(item));
                            selectedFiles.Items.Add(Path.GetFileName(item));
                        }
                       
                    }
                }
            }
        }
        public void UploadFile(FileInfo fileInfo, BackgroundWorker worker)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + ftpService.ftpProperties.Server + "/altdizin" + @"//" + fileInfo.Name);
            request.Credentials = new NetworkCredential(ftpService.ftpProperties.Username, ftpService.ftpProperties.Password);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            Stream ftpStream = request.GetRequestStream();
            FileStream file = File.OpenRead(fileInfo.FullName);

            int length = 1024;
            byte[] buffer = new byte[length];

            int bytesRead = 0;
            double total = (double)fileInfo.Length;
            int byteRead = 0;
            double read = 0;
            worker.ReportProgress(20);
            try
            {
                do
                {
                    bytesRead = file.Read(buffer, 0, length);
                    ftpStream.Write(buffer, 0, bytesRead);
                    read += (double)byteRead;
                    worker.ReportProgress(50);
                }
                while (bytesRead != 0);

                file.Close();
                ftpStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (file != null) file.Close();
                if (ftpStream != null) ftpStream.Close();
                worker.ReportProgress(100);
            }
        }
        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            foreach (FileInfo file_ in files)
            {
                UploadFile(file_,(BackgroundWorker)sender);
            }
        }

        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            uploadedLbl.Text = $"Uploaded %{e.ProgressPercentage}";
            cancelUpload.Visible = true;
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Update();
        }

        public void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            uploadedLbl.Text = "Files Uploaded!";
            cancelUpload.Visible = false;
            selectedFiles.Items.Clear();
            files.Clear();
        }

        public void UploadFiles_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.MailForm(files.Count))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
        }
        public void cancelUpload_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
