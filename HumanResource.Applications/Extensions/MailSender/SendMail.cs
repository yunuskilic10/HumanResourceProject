using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace HumanResource.Applications.Extensions.MailSender
{
    public static class SendMail
    {

        public static void EmailSend(string email, string info, int? randomCode = null)
        {
            /***********************************************************************Email Address**********************/
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Begny Human Resource", "Yourailadress");

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", email);



            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"{info}  " + randomCode;



            MimeMessage mimeMessage = new();
            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);



            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Begny Human Resource";
            MailKit.Net.Smtp.SmtpClient client = new();
            /**********Smtp Address**Smptp Türkiye(587)****************************************************************************/
            client.Connect("smtp.gmail.com", 587, false);
            //client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
            /**********Smtp Address**Smptp Türkiye(587)****************************************************************************/
            client.Authenticate("YourMailAddress", "YourPassword");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }

        public static void CreateMail(string privateMail, string info, string password, string mail)
        {
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Begny Human Resource", "YourMailAddress");

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", privateMail);



            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"{info} \n " + "\nYour Mail: " + mail + " \nYour password: " + password + "\n https://begnyproject.azurewebsites.net/";



            MimeMessage mimeMessage = new();
            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);



            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Begny Human Resource";
            MailKit.Net.Smtp.SmtpClient client = new();
            /**********Smtp Address**Smptp Türkiye(587)****************************************************************************/
            client.Connect("smtp.gmail.com", 587, false);
            //client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
            /**********Smtp Address**Smptp Türkiye(587)****************************************************************************/
            client.Authenticate("YourMailAddress", "YourPassword");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }
    }
}
