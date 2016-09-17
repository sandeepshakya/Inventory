using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

namespace Inventory.FORMS.System_Admin
{
    public partial class SystemAdminLogin1 : System.Web.UI.Page
    {
        SystemAdmin obj = new SystemAdmin();
        int str;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["username"] = null;
        }
       

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            try
            {
                var loginService = new LoginService();
                bool result = true; //loginService.Login(txtUserName.Text, txtPassword.Text, "SystemAdmin", "0");

                if (result)
                {
                    Session["username"] = txtUserName.Text;
                    Response.Redirect("~/FORMS/System Admin/Home.aspx");
                }
                //else if (str == 0)
                //{
                //    lblError.Text = "Already Login!!!";
                //}
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
}