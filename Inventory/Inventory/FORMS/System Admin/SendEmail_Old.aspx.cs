using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;
using System.Net.Mail;

public partial class FORMS_System_Admin_SendEmail : System.Web.UI.Page
{
    SystemAdmin objSa = new SystemAdmin();
    string id; 
    string mail; 
    string name;
    string cname;
    private Random rnd;
    private string GenerateString()
    {

        rnd = new Random();

        string validatingText = null;

        for (int a = 0; a < 8; a++)
        {

            char chr = (char)rnd.Next(65, 90);

            validatingText += chr.ToString();

        }

        return validatingText;

    }

    public static void SendEmail(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)
    {
        //MailAddress from = new MailAddress(yourGmailUserName, yourName);
        //MailAddress to = new MailAddress(toEmail, toName);
        //MailMessage message = new MailMessage(from, to);
        //message.Subject = subject;
        //message.Body = body;
        //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);//Edit this, if you like to use another
        //NetworkCredential nc = new NetworkCredential(yourGmailUserName, yourGmailPassword);
        //smtpClient.EnableSsl = true;
        //smtpClient.UseDefaultCredentials = false;
        //smtpClient.Credentials = nc;
        //smtpClient.Send(message);
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {

        txtPassword.Text = GenerateString();
        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        cname = Request.QueryString["cname"];
        id = Request.QueryString["id"];
        mail = Request.QueryString["mail"];
        name = Request.QueryString["name"];
        string body;

        body = "Dear " + name + " Your Login Details are... ";
        body += "Username =  ADMIN  Password = " + txtPassword.Text;

        try
        {
            //SendEmail("Admin@IMS", "systemadmin.ims@gmail.com", "sysims!@#$", name, mail, "Your Login Details", body);
            //Response.Write("Mail Sent Successfully");

            objSa.UserName = txtUserName.Text;
            
            objSa.CompanyId = Convert.ToInt32( id);



           int x= objSa.InsertAdminCompany();


           objSa.CompanyName = cname;
           objSa.Status = "Approved";
           int no=objSa.ApprovedCompany();



           objSa.CompanyId = Convert.ToInt32(id);
           objSa.Licence = Convert.ToInt32(txtLic.Text);
           objSa.ADate = DateTime.Now;
           objSa.Duration = "6";

           objSa.EDate = (DateTime.Now.AddMonths(6));

          int y= objSa.InsertLicense();

          Response.Write("Activated Successfully");

            //        sa.UserName = txtUsername.Text;
            //        sa.Password = txtPassword.Text;
            //        //sa.CompanyId =Convert.ToInt32( companyid);
        }
       catch(Exception ex) 
        {
            Response.Write(ex.Message);
       }
    }
    protected void Button1_ServerClick(object sender, EventArgs e)
    {

    }
}




//If usrrep = True Then
//          Dim intCompanyId As Integer = LoggedinUser.UserDetails.CompanyID
//          Dim strUserId As String = LoggedinUser.UserDetails.UserId
//          If objUtility.InsertInThingstodo(strUserId, intCompanyId, txtmessage.Text) <> 0 Then
//              Lbltxt.Text = "Things added Successfully"
//              txtmessage.Text = ""
//              Dim sb As New StringBuilder()
//              sb.Append("<script>")
//              sb.Append("window.opener.location.href")
//              sb.Append("=window.opener.location.href;")
//              sb.Append("</script>")
//              Page.ClientScript.RegisterStartupScript(GetType(Page), "Search", sb.ToString())
//          End If
//      End If