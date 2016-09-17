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

public partial class FORMS_System_Admin_SystemAdminLogin : System.Web.UI.Page
{
    SystemAdmin obj = new SystemAdmin();

    int str;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["username"] = null;
   
    }
    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            obj.UserName = txtUserName.Text;
            obj.Password = txtPassword.Text;
            str = obj.SystemAdminLogin();
            if (str == 1)
            {
                Session["username"] = txtUserName.Text;
                Response.Redirect("~/FORMS/System Admin/Home.aspx");
            }
            else if (str == 0)
            {
                lblError.Text = "Already Login!!!";
            }
            else
            {
                lblError.Text = "Invalid User Id or Password";
            }

        }
        catch (Exception ex)
        {
            lblError.Text = "Invalid Username or Password";
        }
    }
}
