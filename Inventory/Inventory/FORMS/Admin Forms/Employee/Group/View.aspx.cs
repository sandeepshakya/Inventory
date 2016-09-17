using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.Admin_Forms.Employee.Group
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                LoadGroup();
            this.ActiveSideBarMenu();
            grdGroup.UseAccessibleHeader = true;
            grdGroup.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liEmployee = (HtmlGenericControl)Master.FindControl("liEmployee");
            liEmployee.Attributes.Add("class", "treeview active");
            HtmlGenericControl liGroup = (HtmlGenericControl)Master.FindControl("liGroup");
            liGroup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liVGroup = (HtmlGenericControl)Master.FindControl("liVGroup");
            liVGroup.Attributes.Add("class", "active");

        }

        private void LoadGroup()
        {
            DataTable dt = new DataTable();
            long companyId = 2;//int.Parse(Session["CompanyId"].ToString());
            var catgoryService = new CategoryService();
            //ViewState["dtbl"] = catgoryService.GetCategoryList(companyId);
            // dt = this.ToDataTable(catgoryService.GetCategoryList(companyId));
            grdGroup.DataSource = catgoryService.GetCategoryList(companyId); ;
            grdGroup.DataBind();

        }
    }
}