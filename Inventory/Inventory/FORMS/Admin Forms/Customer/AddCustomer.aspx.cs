using System;
using System.Web.UI.HtmlControls;

namespace Inventory.FORMS.Admin_Forms.Customer
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActiveSideBarMenu();
                 }
        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liCustomers = (HtmlGenericControl)Master.FindControl("liCustomers");
            liCustomers.Attributes.Add("class", "treeview active");
            HtmlGenericControl liACustomers = (HtmlGenericControl)Master.FindControl("liACustomers");
            liACustomers.Attributes.Add("class", "active");
           
        }
        
    }
}