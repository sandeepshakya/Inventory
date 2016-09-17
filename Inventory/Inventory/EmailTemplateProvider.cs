using System;
using System.IO;

namespace Inventory
{
    public static class EmailTemplateProvider
    {
        public static string PopulateBody(string userName, string emailType, string password,string detail1="",string detail2="",string detail3="")
        {
            string body = string.Empty;

            string templateUrl = emailType.ToLower() == "signup" ? AppDomain.CurrentDomain.BaseDirectory + "EmailTemplates\\CompanyRegistration.html"
                : AppDomain.CurrentDomain.BaseDirectory + "EmailTemplates\\AdministratorRegistration.html";

            using (var reader = new StreamReader(templateUrl))
            {
                body = reader.ReadToEnd();
            }

            body = body.Replace("{UserName}", userName);

            if (emailType.ToLower() != "signup")
            {
                body = body.Replace("{PCP}", detail1);
                body = body.Replace("{EmailAddress}", detail2);
                body = body.Replace("{ContactNumber}", detail3);
            }
            return body;
        }
    }
}