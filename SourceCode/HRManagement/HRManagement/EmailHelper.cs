using System;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace HRManagement
{
    public class EmailHelper
    {
        public static void SendEmail(string host, int port, string from, string password, string to, string subject, string html)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            var smtp = new SmtpClient();
            smtp.CheckCertificateRevocation = false;
            smtp.Connect(host, port, SecureSocketOptions.StartTls);
            smtp.Authenticate(from, password);
            smtp.Send(email);
            smtp.Disconnect(true);
        }


    }
}
