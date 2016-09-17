using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.Admin_Forms.Employee.Group
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActiveSideBarMenu();
        }
        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liEmployee = (HtmlGenericControl)Master.FindControl("liEmployee");
            liEmployee.Attributes.Add("class", "treeview active");
            HtmlGenericControl liGroup = (HtmlGenericControl)Master.FindControl("liGroup");
            liGroup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liEGroup = (HtmlGenericControl)Master.FindControl("liEGroup");
            liEGroup.Attributes.Add("class", "active");

        }
    }
}