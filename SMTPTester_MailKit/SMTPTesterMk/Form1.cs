

namespace SMTPTesterMk
{
    using MailKit.Net.Smtp;
    using MailKit.Security;
    using MimeKit;

    using MimeKit.Text;

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

        private void EnviarCorreo()
        {
           
            try
            {


                //txtForm.Text, txtTo.Text.Trim(), "SMTP Tester", "Mail de prueba"
                var msg = new MimeMessage();
                msg.To.Add(MailboxAddress.Parse(txtTo.Text.Trim()));
                msg.From.Add(MailboxAddress.Parse(txtForm.Text.Trim()));
                msg.Subject = "SMTP Tester Mk";
                msg.Body = new TextPart(TextFormat.Plain)
                {
                    Text = "Mensaje de prueba"
                };

                int intPort = 587;
                int.TryParse(txtPort.Text.Trim(), out intPort);


                using var smtp = new SmtpClient();

                SecureSocketOptions socketOptions = SecureSocketOptions.Auto;
                if (rdbUseSSL.Checked)
                {
                    socketOptions = SecureSocketOptions.SslOnConnect;
                }
                else if (rdbUseStartTls.Checked)
                {
                    socketOptions = SecureSocketOptions.StartTls;

                }

                string server = cmbServer.Text.Trim();

                smtp.Connect(server, intPort, socketOptions);
                smtp.Authenticate(txtLogin.Text.Trim(), txtPass.Text.Trim());
                
                smtp.Send(msg);
                smtp.Disconnect(true);

                MessageBox.Show(@"Parece que todo guay ;-)");
            }
            catch (Exception ex)
            {
                log(ex.Message);
                log(ex.InnerException?.Message);
                MessageBox.Show("error:" + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}