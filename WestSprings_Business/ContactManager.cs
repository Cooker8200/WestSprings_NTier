using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WestSprings_ViewModels;

namespace WestSprings_Business
{
    public class ContactManager
    {
        public void SendMessage(WestSprings_ViewModels.WestSprings_Contact model)
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            //var address = ((Leadership)Enum.ToObject(typeof(Leadership), model.SendToID)).ToString();
            message.To.Add(new MailAddress(/*address + */"Cooker8200@hotmail.com"));
            message.From = new MailAddress(" ");
            message.Subject = "West Springs Contact";
            message.Body = string.Format(body, model.Email, model.Name, model.Message);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "Cooker8200@hotmail.com ",
                    Password = "MATTcook82189804 "
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }

        }
    }
}
