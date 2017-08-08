using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            try
            {
                EnviarCorreo();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void EnviarCorreo()
        {
            SmtpClient smtp = null;

            try
            {
                smtp = new SmtpClient()
                {
                    Host = txtServer.Text.Trim()
                };

                if (int.TryParse(txtPort.Text.Trim(), out int intPort))
                {
                    smtp.Port = intPort;
                }

                if (!chkAnonymous.Checked)
                {
                    smtp.Credentials = new NetworkCredential()
                    {
                        UserName = txtLogin.Text.Trim(),
                        Password = txtPass.Text.Trim()
                    };
                }

                var msg = new MailMessage(txtForm.Text, txtTo.Text.Trim(), "SMTP Tester", "Mail de prueba");

                smtp.Send(msg);

                MessageBox.Show("Parece que todo guay ;-)");

            }
            catch (Exception e)
            {
                log(e.Message);
                log(e.InnerException?.Message);
                MessageBox.Show("error:" + e.Message);
            }
            finally
            {
                smtp?.Dispose();
            }

        }

        private void chkAnonymous_CheckedChanged(object sender, EventArgs e)
        {
            txtLogin.Enabled = !chkAnonymous.Checked;
            txtPass.Enabled = !chkAnonymous.Checked;
        }


        void log(string msg)
        {
            if (string.IsNullOrEmpty(msg)) return;
            txtLog.Text += Environment.NewLine + msg;
        }


    }
}
