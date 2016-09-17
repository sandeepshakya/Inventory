using System;
using System.Web.UI.HtmlControls;

public partial class Managecustomers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // this.ActiveSideBarMenu();
    }
    protected void ActiveSideBarMenu()
    {
        HtmlGenericControl liCustomers = (HtmlGenericControl)Master.FindControl("liCustomers");
        liCustomers.Attributes.Add("class", "treeview active");
        HtmlGenericControl liHCustomers = (HtmlGenericControl)Master.FindControl("liHCustomers");
        liHCustomers.Attributes.Add("class", "active");
    }
}
