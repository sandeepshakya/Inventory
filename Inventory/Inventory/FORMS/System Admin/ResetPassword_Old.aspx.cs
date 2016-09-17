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

public partial class FORMS_System_Admin_ResetPassword : System.Web.UI.Page
{
    int res;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        try
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/FORMS/System Admin/SystemAdminLogin.aspx");
            }
            else
            {
                //Master.AddText = "My Account";
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void btnResetPassword_Click(object sender, EventArgs e)
    {
        try
        {
            SystemAdmin objReset = new SystemAdmin();
            objReset.UserName = txtUserName.Text;
            objReset.NewPassword = txtNewPassword.Text;
            res = objReset.ChangePassword();
            //lblMessage.Text = res.ToString();
            if (res == 1)
            {
                lblMessage.Text = "Password Changed Successfully";
            }
            else
            {
                lblMessage.Text = "UserName Not Found";
            }

        }
        catch (Exception ex)
        {
        }
    }
   
}
