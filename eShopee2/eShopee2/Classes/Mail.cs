using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace eShopee2.Classes
{
    public class Mail
    {
        public Mail(string receiver, string subject, string message)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("anshulrox93@gmail.com", "Science11@");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("anshulrox93@gmail.com");
            mail.To.Add(receiver);
            mail.Subject = subject;
            mail.Body = message;

            //Attachment attachment = new Attachment(filename);
            //mail.Attachments.Add(attachment);

            SmtpServer.Send(mail);
        }
    }
}












 o
