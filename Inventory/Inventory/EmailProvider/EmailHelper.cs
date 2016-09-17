using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Inventory.EmailProvider
{
    public static class EmailHelper
    {
        public static bool SendEmail(string toEmailId, string mailBody,string subject)
        {
            var sendFrom = new MailAddress(ConfigurationManager.AppSettings["SendFrom"]);
            MailAddress sendTo = new MailAddress(toEmailId.ToString());
            MailAddress bcc = sendFrom;
            MailMessage msg = new MailMessage(sendFrom, sendTo);
            MailMessage msg1 = new MailMessage(sendFrom, bcc);
            msg.Subject = subject;
           // string imagePath = AppDomain.CurrentDomain.BaseDirectory + "Images\\Email\\Shopplu.jpg";

          //  LinkedResource objLinkedRes = new LinkedResource(imagePath, "image/jpg");
           // objLinkedRes.ContentId = "shopplu-logo";

            AlternateView objHTLMAltView = AlternateView.CreateAlternateViewFromString("<img src='cid:Inventory-logo' /><br/><br/>" + mailBody,
                        new System.Net.Mime.ContentType("text/html"));
           // objHTLMAltView.LinkedResources.Add(objLinkedRes);

            msg.AlternateViews.Add(objHTLMAltView);
            msg.IsBodyHtml = true;

            msg.Priority = MailPriority.High; // EMAILS ARE ALWAYS RECEIVING IN SPAM FOLDER. NEED TO SEND TO INBOX OF RECIPIENT.
            msg.Body = objHTLMAltView.ToString();

            string smtpAddress = ConfigurationManager.AppSettings["SMTPClient"];
            int portNumber = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
            bool enableSSL = bool.Parse(ConfigurationManager.AppSettings["EnableSSL"]);
            using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
            {
                smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["SendFrom"], ConfigurationManager.AppSettings["NetworkCredential"]);
                smtp.EnableSsl = enableSSL;
                smtp.Send(msg);
                return true;
            }
        }

        public static bool ForgotPassword(string emailId, string mailBody, string subject)
        {
            var sendFrom = new MailAddress(ConfigurationManager.AppSettings["userName"]);
            MailAddress toAddress = new MailAddress(emailId);
            SmtpClient smtp = new SmtpClient()
            {
                Host= ConfigurationManager.AppSettings["host"],
                Port=int.Parse(ConfigurationManager.AppSettings["port"]),
                EnableSsl=true,
                Credentials=new System.Net.NetworkCredential(ConfigurationManager.AppSettings["userName"],ConfigurationManager.AppSettings["password"])
            };
            MailAddress sendTo = new MailAddress(emailId.ToLower());
            MailAddress bcc = sendFrom;
            MailMessage msg = new MailMessage(sendFrom, sendTo);
            MailMessage msg1 = new MailMessage(sendFrom, bcc);
            msg.Subject = subject;
            string imagePath = AppDomain.CurrentDomain.BaseDirectory + "Images\\Email\\Shopplu.jpg";

            LinkedResource objLinkedRes = new LinkedResource(imagePath, "image/jpg");
            objLinkedRes.ContentId = "shopplu-logo";

            AlternateView objHTLMAltView = AlternateView.CreateAlternateViewFromString("<img src='cid:shopplu-logo' /><br/><br/>" + mailBody,
                        new System.Net.Mime.ContentType("text/html"));
            objHTLMAltView.LinkedResources.Add(objLinkedRes);

            msg.AlternateViews.Add(objHTLMAltView);
            msg.IsBodyHtml = true;

            msg.Priority = MailPriority.High; // EMAILS ARE ALWAYS RECEIVING IN SPAM FOLDER. NEED TO SEND TO INBOX OF RECIPIENT.

           // SmtpClient client = new SmtpClient(ConfigurationManager.AppSettings["SMTPClient"], Convert.ToInt32(ConfigurationManager.AppSettings["Port"]));
           // client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["SendFrom"], ConfigurationManager.AppSettings["NetworkCredential"]);
            //client.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSSL"]);
            try
            {
                smtp.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
