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

public partial class FORMS_Master_Page_SystemAdminMaster_SystemAdminMaster : System.Web.UI.MasterPage
{
    SystemAdmin obj = new SystemAdmin();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   

    protected void imgbtnHome_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/Home.aspx");
    }
    protected void imgbtnCompMgmt_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/Admin Manage.aspx");
    }
    protected void imgbtnRstPass_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/ResetPassword.aspx");
    }
    protected void imgbtnLogout_Click(object sender, ImageClickEventArgs e)
    {
        obj.UserName = Convert.ToString(Session["username"]);
        int ers = obj.SystemAdminLogoff();
        Session.Abandon();
        Response.Redirect("~/FORMS/System Admin/SystemAdminLogin.aspx");
    }
}
