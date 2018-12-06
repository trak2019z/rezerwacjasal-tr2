﻿using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var EmailPassword = "Plazmotronix";
            var EmailLogin = "webapp0@outlook.com";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(EmailLogin, EmailPassword);
            smtp.EnableSsl = true;

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(email);

            var Subject = "Potwierdzenie wysłania wiadomości - system rezerwacji sal - ";
            Subject = Subject + subject;
            mailMessage.Subject = Subject;

            var Body = message;
            Body = Body + "\n \n \n Wiadomość wygenerowana automatycznie. Prosimy na nią nie odpowiadać.";
            Body = Body + "\n System rezerwacji sal - Bulbulatron 2000.";
            mailMessage.Body = Body;

            mailMessage.From = new MailAddress(EmailLogin);
            try
            {
                smtp.Send(mailMessage);
            }
            catch
            {
            }
            return Task.CompletedTask;
        }
    }
}
