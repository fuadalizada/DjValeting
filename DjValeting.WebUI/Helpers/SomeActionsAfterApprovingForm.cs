using MailKit.Net.Smtp;
using MimeKit;

namespace DjValeting.WebUI.Helpers
{
    public class SomeActionsAfterApprovingForm
    {
        public delegate void SendMailAfterApprovingForm();
        public event SendMailAfterApprovingForm FormApproved;
        public string ClientEmail { get; set; }

        public void OnSendMailAfterApprovingForm(string clientEmail)
        {
            ClientEmail = clientEmail;
            if (FormApproved is not null)
            {
                FormApproved();
            }
        }

        public void SendEmail()
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("moises.schneider52@ethereal.email")); //this is the temporary email from https://ethereal.email/ and you can just get the new email if you click on create account button in this site
            email.To.Add(MailboxAddress.Parse(ClientEmail)); //client email also should be valid email because below on the line 31 you have to send valid credentials like username and password of this email address to authenticate by google.
            //for testing purpose you can use the same email in https://ethereal.email/
            email.Subject = "Booking request acceptance mail";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = "<h1>Dear client, your booking request has been accepted</h1>" };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("moises.schneider52@ethereal.email", "q6zuRSH7Td4RHGXNMK"); //these are temporary from the site https://ethereal.email/
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
