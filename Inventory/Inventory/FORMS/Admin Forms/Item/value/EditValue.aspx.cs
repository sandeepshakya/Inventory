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

public partial class FORMS_Admin_Forms_Item_value_EditValue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ActiveSideBarMenu();
    }

    protected void ActiveSideBarMenu()
    {
        HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
        liInventorySetup.Attributes.Add("class", "treeview active");
        HtmlGenericControl liEValue = (HtmlGenericControl)Master.FindControl("liEValue");
        liEValue.Attributes.Add("class", "active");
    }
}
