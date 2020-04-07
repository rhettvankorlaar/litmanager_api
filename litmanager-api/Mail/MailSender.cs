using litmanager_api.Options;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Mail
{
    public class MailSender : IMailSender
    {
        private readonly EmailConfiguration _emailConfiguration;

        public MailSender(EmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        public void SendMail(Receiver receiver, string subject, string content)
        {
			var message = new MimeMessage();
			message.To.Add(new MailboxAddress(receiver.FirstName + " " + receiver.LastName, receiver.Email));
			message.From.Add(new MailboxAddress("LIT Manager", _emailConfiguration.From));

			message.Subject = subject;

			//Send html
			message.Body = new TextPart(TextFormat.Html)
			{
				Text = content
			};

			//Be careful that the SmtpClient class is the one from Mailkit not the framework!
			using var emailClient = new SmtpClient();
			//The last parameter here is to use SSL (Which you should!)
			emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.Port, true);

			//Remove any OAuth functionality as we won't be using it. 
			emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

			emailClient.Authenticate(_emailConfiguration.UserName, _emailConfiguration.Password);

			emailClient.Send(message);

			emailClient.Disconnect(true);
		}
    }
}
