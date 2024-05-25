using System.Net.Mail;
using System.Net;

namespace PublishingCenter
{
    public class Mailer
    {
        public static void SendMessage(string mailTo, string mailSubject, string mailBody)
        {
            var fromAddress = new MailAddress("ogurchikvk0907@gmail.com", "BookWise Publishing");
            var toAddress = new MailAddress(mailTo, "To Name");
            const string fromPassword = "ltgg wupm kggo yiol";
            string subject = mailSubject;
            string body = mailBody;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        public static void SendMessage(string mailTo, string mailSubject, string mailBody, string attachmentPath)
        {
            var fromAddress = new MailAddress("ogurchikvk0907@gmail.com", "BookWise Publishing");
            var toAddress = new MailAddress(mailTo, "To Name");
            const string fromPassword = "ltgg wupm kggo yiol";
            string subject = mailSubject;
            string body = mailBody;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            MailMessage mail = new MailMessage();
            mail.From = fromAddress;
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;
            mail.Attachments.Add(new Attachment(attachmentPath));
            smtp.Send(mail);
        }
    }
}
