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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/FORMS/System Admin/SystemAdminLogin.aspx");
            }


            Master.Attributes.Add("Text", "Home");
        }
        catch (Exception ex)
        {
        }
    }

    protected void lnkbtnRegComp_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/Registration.aspx");
    }
    protected void imgbtnRegComp_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/Registration.aspx");
    }
    protected void lnkbtnMngComp_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/CompMgmt.aspx?no=Activate");
    }
    protected void imgbtnMngComp_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/CompMgmt.aspx?no=Activate");
    }
    protected void lnkbtnMngUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/AdminManage.aspx");
    }
    protected void imgbtnMngUser_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/FORMS/System Admin/AdminManage.aspx");
    }
}
