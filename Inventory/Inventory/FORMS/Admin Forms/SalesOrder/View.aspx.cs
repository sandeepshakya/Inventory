using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.Admin_Forms.SalesOrder
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindEmptyGrid();
                BindGrid();
            }

        }

        private void BindEmptyGrid()
        {
            gridSo.DataSource = new List<Service.ViewModel.SalesOrderProducts>();
            gridSo.DataBind();
        }

        private void BindGrid()
        {
            var soService = new SalesOrderService();
            long companyId = 2; //long.Parse(Session["CompanyId"].ToString());
            var searchResult = soService.SearchResult(companyId);
            var grandTotal = searchResult.Select(so => so.Total).Sum();
            searchResult.All(aa => aa.GrandTotal == grandTotal);

            gridSo.DataSource = searchResult;
            gridSo.DataBind();

            Literal ltrlGrandTotal = gridSo.FooterRow.FindControl("ltrlGrandTotal") as Literal;
            if (ltrlGrandTotal != null)
                ltrlGrandTotal.Text = string.Format("Grand Total : $ {0}", grandTotal);
        }
    }
}