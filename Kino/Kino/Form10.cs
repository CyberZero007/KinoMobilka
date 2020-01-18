using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Kino
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("AntonZero007@yandex.ru", username.Text);
            MailAddress toAddress = new MailAddress(to.Text);

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Обратная связь";
                mailMessage.Body = body.Text;

                smtpClient.Host = "smtp.yandex.ru";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Antonio1999");

                smtpClient.Send(mailMessage);
                MessageBox.Show("Спасибо за то, что помогаете сделать приложение лучше. Мы свяжемся с вами в течение суток.", "Обратная связь");
            }
        }
    }
}
