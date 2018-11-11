using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ArhSite.Services
{
   public class EmailSender
   {
      private readonly Configuration _config;

      public EmailSender()
      {
         _config = Configuration.GetConfiguration();
      }

      public void SendContact(string firstname, string email, string phone, string message)
      {
         try {
            if (string.IsNullOrWhiteSpace(firstname)) {
               throw new Exception("The first name field cannot be empty.");
            }



            if (string.IsNullOrWhiteSpace(email)) {
               throw new Exception("The e-mail field cannot be empty.");
            }

            MailMessage mail = new MailMessage();
            mail.To.Add(_config.Address);

            mail.From = new MailAddress(email);
            mail.Subject = "Mesaj de la " + firstname;
            mail.Body = message + "\nPhone number: " + phone;

            using (var smtp = new SmtpClient()) {
               smtp.Credentials = new NetworkCredential() {
                  UserName = _config.Username,
                  Password = _config.Password
               };
               smtp.Host = _config.Host;
               smtp.Port = _config.Port;
               smtp.EnableSsl = _config.IsSslEnabled;
               smtp.Send(mail);
            }
         } catch (Exception ex) {
            throw ex;
         }
      }
   }
}