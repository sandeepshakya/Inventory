using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Service;
using Service.ViewModel;

namespace Inventory.FORMS.Admin_Forms.SalesOrder
{
    public partial class Add : System.Web.UI.Page
    {
        private static IReadOnlyCollection<SalesOrderProducts> salesOrderProducts = new List<SalesOrderProducts>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindDropdownList();
                BindEmptyPoGrid();
            }

            grdProductList.UseAccessibleHeader = true;
            grdProductList.HeaderRow.TableSection = TableRowSection.TableHeader;
            ActiveSideBarMenu();
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liSalesOrder = (HtmlGenericControl)Master.FindControl("liSalesOrder");
            liSalesOrder.Attributes.Add("class", "treeview active");
            HtmlGenericControl liSoView = (HtmlGenericControl)Master.FindControl("liSoView");
            liSoView.Attributes.Add("class", "active");
        }

        protected void ddlSalesOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSalesOrder.SelectedIndex > 0)
            {
                salesOrderNumber.Value = ddlSalesOrder.SelectedValue;
                BindPoDetails();             
            }           
        }

        private void BindPoDetails()
        {
            var salesOrderService = new SalesOrderService();
            var poList = salesOrderService.SearchResult(ddlSalesOrder.SelectedItem.Text);
            hdnFieldBuyer.Value = poList.FirstOrDefault().Buyer;

            salesOrderProducts = poList;

            if (poList.Count > 0)
            {
                cke_2_contents.InnerHtml = poList.FirstOrDefault().ShippingAddress;
               
                decimal subTotal = poList.Select(po => po.Total).Sum();
                decimal grandTotal = subTotal;
                lblGrandTotal.InnerText = grandTotal.ToString();
                txtSubTotal.Value = subTotal.ToString();
            }

            grdProductList.DataSource = poList;
            grdProductList.DataBind();
        }

        private void BindEmptyPoGrid()
        {
            grdProductList.DataSource = new List<SalesOrderProducts>();
            grdProductList.DataBind();
        }
        private void BindDropdownList()
        {
            PopulateDropDownList.FillSalesOrder(ddlSalesOrder);
        }

        protected void btn_order_Click(object sender, EventArgs e)
        {
            var soService = new SalesOrderService();

            // Updating Sales Order.
            var model = new Model.Models.SalesOrder();
            model.Comments = ck_editor.Value;
            model.ApprovedQnty = 234;  // SHYAM : TODO: Need to change UI and make Stock Column Editable and apply logics for recalculate Sub and Grand Total
            model.PaymentMode = order_payment_type.Value;
            model.PONumber = ddlSalesOrder.SelectedItem.Text;
            model.Status = Service.Enums.SalesOrderStatus.Issued.ToString();
            model.TotalPrice = decimal.Parse(lblGrandTotal.InnerText);
            model.CompanyId = 2; //Session["CompanyId"];
            model.Number = ddlSalesOrder.SelectedValue;

            var soProducts = new List<SalesOrderProducts>();

            soProducts = salesOrderProducts.ToList();

            string result = soService.IssueOrder(model, soProducts);
            if (!string.IsNullOrEmpty(result))
                this.Master.LabelMessage = string.Format("Sales Order '{0}' Issued to Customer '{1}'", model.Number, hdnFieldBuyer.Value);

            hdnFieldBuyer.Value = string.Empty;
            cke_2_contents.InnerHtml = string.Empty;
            lblGrandTotal.InnerText = string.Empty;
            txtSubTotal.Value = string.Empty;
            salesOrderProducts.ToList().Clear();
            ddlSalesOrder.SelectedIndex = 0;
            salesOrderNumber.Value = string.Empty;
            BindEmptyPoGrid();
        }
    }
}