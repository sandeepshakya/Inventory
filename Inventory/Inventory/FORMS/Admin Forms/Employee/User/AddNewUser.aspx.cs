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

public partial class Form_Admin_Employee_Management_User_Managemant_AddNewUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ActiveSideBarMenu();
    }
    protected void ActiveSideBarMenu()
    {
        HtmlGenericControl liEmployee = (HtmlGenericControl)Master.FindControl("liEmployee");
        liEmployee.Attributes.Add("class", "treeview active");
        HtmlGenericControl liUser = (HtmlGenericControl)Master.FindControl("liUser");
        liUser.Attributes.Add("class", "treeview active");
        HtmlGenericControl liAUser = (HtmlGenericControl)Master.FindControl("liAUser");
        liAUser.Attributes.Add("class", "active");

    }
}
