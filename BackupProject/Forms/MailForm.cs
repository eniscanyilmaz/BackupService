using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupProject.Forms
{
    public partial class MailForm : Form
    {
        int filesCount = 0;
        public MailForm(int filesCount)
        {
            this.filesCount = filesCount;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailManager mailManager = new MailManager(mailadress, filesCount, message);
                mailManager.MailSend();
            }
            finally
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
