using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.System_Admin
{
    public partial class Test : System.Web.UI.Page
    {
        SystemAdmin objCount = new SystemAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            objCount.Status = "Approved";
            objCount.CompanyName = null;
            DataSet ds = objCount.SearchCompanyName();
            gridCompanies.DataSource = ds;
            gridCompanies.DataBind();

        }
        protected void ddlSrcType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            objCount.Status = "Trial";
            objCount.CompanyName = null;
            DataSet ds = objCount.SearchCompanyName();
            gridCompanies.DataSource = ds;
            gridCompanies.DataBind();
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
        protected void btnActivate_Click(object sender, EventArgs e)
        {

        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}