using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmailUsingSMTP
{
    public partial class frmSMTP : Form
    {
        public frmSMTP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {


            sendEmail();


        }

        public void sendEmail()
        {
            try
            {
           
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                message.From = new MailAddress(txtEmailFrom.Text.Trim());
                message.To.Add(new MailAddress(txtEmailTo.Text.Trim()));
                message.Subject = txtEmailSubject.Text.Trim() + " on " + DateTime.Now.ToString();
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = txtEmailMessage.Text.Trim() + " on " + DateTime.Now.ToString();
                smtp.Port = Convert.ToInt32(txtEmailPort.Text.Trim());
                smtp.Host = txtEmailHost.Text.Trim(); //for gmail host  



                smtp.EnableSsl = true;  //ENABLE SSL
                smtp.UseDefaultCredentials = false;




                smtp.Credentials = new NetworkCredential(txtEmailFrom.Text.Trim(), txtEmailPassword.Text.Trim());
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.TargetName = txtEmailTarget.Text.Trim();

                                


                smtp.Send(message);

                MessageBox.Show("Email sent to " + txtEmailTo.Text.ToString());



            }
            catch (Exception ex)
            {

                string strEmailError = ex.Message.ToString();
                txtError.Text = ex.Message.ToString();
                MessageBox.Show(strEmailError);
            }

           
        }





    }
}
