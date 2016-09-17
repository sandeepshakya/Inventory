using System;

using Service;

namespace Inventory.FORMS.Admin_Forms
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();

            bool result = true; //loginService.Login(txtUsername.Text, txtPassword.Text, "CompanyAdmin", txtCompanyId.Text.Trim());

            if (result)
            {
                Session["CompanyId"] = txtCompanyId.Text.Trim();
                Session["username"] = txtUsername.Text.Trim();
                Response.Redirect("~/FORMS/Admin Forms/Dashboard.aspx");
            }
        }
    }
}