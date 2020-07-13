namespace BackupProject
{
    partial class BackupForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFiles = new System.Windows.Forms.Button();
            this.selectedFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UploadFiles = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.uploadedLbl = new System.Windows.Forms.Label();
            this.cancelUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFiles
            // 
            this.SelectFiles.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectFiles.Location = new System.Drawing.Point(435, 38);
            this.SelectFiles.Name = "SelectFiles";
            this.SelectFiles.Size = new System.Drawing.Size(151, 48);
            this.SelectFiles.TabIndex = 0;
            this.SelectFiles.Text = "Select Files";
            this.SelectFiles.UseVisualStyleBackColor = true;
            this.SelectFiles.Click += new System.EventHandler(this.selectFiles_Click);
            // 
            // selectedFiles
            // 
            this.selectedFiles.FormattingEnabled = true;
            this.selectedFiles.Location = new System.Drawing.Point(26, 38);
            this.selectedFiles.Name = "selectedFiles";
            this.selectedFiles.Size = new System.Drawing.Size(403, 199);
            this.selectedFiles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Files";
            // 
            // UploadFiles
            // 
            this.UploadFiles.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UploadFiles.Location = new System.Drawing.Point(435, 189);
            this.UploadFiles.Name = "UploadFiles";
            this.UploadFiles.Size = new System.Drawing.Size(151, 48);
            this.UploadFiles.TabIndex = 3;
            this.UploadFiles.Text = "Upload Files";
            this.UploadFiles.UseVisualStyleBackColor = true;
            this.UploadFiles.Click += new System.EventHandler(this.UploadFiles_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 253);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(455, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // uploadedLbl
            // 
            this.uploadedLbl.AutoSize = true;
            this.uploadedLbl.Location = new System.Drawing.Point(372, 279);
            this.uploadedLbl.Name = "uploadedLbl";
            this.uploadedLbl.Size = new System.Drawing.Size(70, 13);
            this.uploadedLbl.TabIndex = 5;
            this.uploadedLbl.Text = "Uploaded %0";
            // 
            // cancelUpload
            // 
            this.cancelUpload.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelUpload.Location = new System.Drawing.Point(487, 253);
            this.cancelUpload.Name = "cancelUpload";
            this.cancelUpload.Size = new System.Drawing.Size(99, 40);
            this.cancelUpload.TabIndex = 6;
            this.cancelUpload.Text = "Cancel Upload";
            this.cancelUpload.UseVisualStyleBackColor = true;
            this.cancelUpload.Click += new System.EventHandler(this.cancelUpload_Click);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 305);
            this.Controls.Add(this.cancelUpload);
            this.Controls.Add(this.uploadedLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.UploadFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedFiles);
            this.Controls.Add(this.SelectFiles);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BackupForm";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectFiles;
        private System.Windows.Forms.ListBox selectedFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UploadFiles;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label uploadedLbl;
        private System.Windows.Forms.Button cancelUpload;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

