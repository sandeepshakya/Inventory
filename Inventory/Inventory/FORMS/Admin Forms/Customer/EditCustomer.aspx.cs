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

public partial class EditCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         this.ActiveSideBarMenu();
    }
    protected void ActiveSideBarMenu()
    {
        HtmlGenericControl liCustomers = (HtmlGenericControl)Master.FindControl("liCustomers");
        liCustomers.Attributes.Add("class", "treeview active");
        HtmlGenericControl liECustomers = (HtmlGenericControl)Master.FindControl("liECustomers");
        liECustomers.Attributes.Add("class", "active");
    }

}
