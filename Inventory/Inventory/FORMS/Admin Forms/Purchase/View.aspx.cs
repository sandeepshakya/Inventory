using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using System.Web.UI.HtmlControls;

namespace Inventory.FORMS.Admin_Forms.Purchase
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                FillPoGrid();
            this.ActiveSideBarMenu();
            gridPo.UseAccessibleHeader = true;
            gridPo.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liPurchase = (HtmlGenericControl)Master.FindControl("liPurchase");
            liPurchase.Attributes.Add("class", "treeview active");
            HtmlGenericControl liVPurchase = (HtmlGenericControl)Master.FindControl("liVPurchase");
            liVPurchase.Attributes.Add("class", "active");
        }

        private void FillPoGrid()
        {
            long companyId = 2; //long.parse(Session["CompanyId"].ToString());
            var poService = new PurchaseOrderService();
            var result = poService.PurchaseOrderSearchResult(companyId);
            gridPo.DataSource = result;
            gridPo.DataBind();
        }
    }
}