
namespace Inventory.FORMS.Admin_Forms.Purchase
{
    using Inventory.Enums;
    using Service;
    using Service.ViewModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Services;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;
    using PurchaseOrderM = Model.Models.PurchaseOrder;
    public partial class Add : System.Web.UI.Page
    {
        private static List<PurchaseOrderProducts> poProducts = new List<PurchaseOrderProducts>();
        decimal sumFooterValue = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
                BindSupplier();

                Table2.DataSource = poProducts;
                Table2.DataBind();
            }
            this.ActiveSideBarMenu();
            grdProductList.UseAccessibleHeader = true;
            grdProductList.HeaderRow.TableSection = TableRowSection.TableHeader;
            Table2.UseAccessibleHeader = true;
            Table2.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liPurchase = (HtmlGenericControl)Master.FindControl("liPurchase");
            liPurchase.Attributes.Add("class", "treeview active");
            HtmlGenericControl liAPurchase = (HtmlGenericControl)Master.FindControl("liAPurchase");
            liAPurchase.Attributes.Add("class", "active");
        }

        private void BindGrid()
        {
            var productService = new ProductService();
            long companyId = 2; //Session["CompanyId"];
            var result = productService.GetProductList(companyId);

            grdProductList.DataSource = result;
            grdProductList.DataBind();
        }

        // Vendor List
        private void BindSupplier()
        {
            long companyId = 2; //Session["CompanyId"];
            var vendorService = new VendorService();
            var listVendor = vendorService.GetVendorListForDropDown(companyId);

            ddlSupplier.DataSource = listVendor;
            ddlSupplier.DataTextField = "value";
            ddlSupplier.DataValueField = "key";
            ddlSupplier.DataBind();

            ddlSupplier.Items.Insert(0, "--Select--");
        }

        /// <summary>
        /// This code block is written when we change Quantity from UI
        /// recalculates again, but DB model doesn't get synced from 
        /// </summary>
        private void SyncPoDetailsBeforeUpdateSave()
        {
            for (int i = 0; i < Table2.Rows.Count; i++)
            {
                long ProductId = long.Parse(Table2.DataKeys[i].Value.ToString());
                decimal total = 0;

                // HTML Input Controls needed to be used as HtmlInputGenericControl instead of HtmlInputText
                HtmlInputGenericControl txtQty = (HtmlInputGenericControl)Table2.Rows[i].FindControl("txtQty");
                HtmlInputGenericControl txtUnitPrice = (HtmlInputGenericControl)Table2.Rows[i].FindControl("txtUnitPrice");

                total = decimal.Parse(txtQty.Value) * decimal.Parse(txtUnitPrice.Value);

                // Update POProducts List For Final Journey
                // Update existing model

                poProducts.Where(po => po.Id == ProductId)
                    .Select(po => po).ToList().ForEach(x =>
                {
                    x.Quantity = int.Parse(txtQty.Value.ToString());
                    x.UnitPrice = decimal.Parse(txtUnitPrice.Value.ToString());
                    x.Total = total;
                });
            }
        }

        private void UpdateSave()
        {
            var poService = new PurchaseOrderService();
            var model = new List<PurchaseOrderM>();
            var numberRangeService = new NumberRangeService();
            string number = numberRangeService.GenerateRandomNumber("PurchaseOrder");
            long comapnyId = 2; // long.parse(Session["CompanyId"].ToString());

            if (ddlSupplier.SelectedIndex == 0)
            {
                this.Master.LabelMessage = "Please select supplier before purchase";
                return;
            }

            SyncPoDetailsBeforeUpdateSave();

            var listPo = poProducts.Select(po => new PurchaseOrderM
            {
                CompanyId = comapnyId,
                Number = number,
                Desc = string.Empty,
                DueDate = DateTime.UtcNow.AddDays(15),
                OrderDate = DateTime.UtcNow,
                OrderedQty = po.Quantity,
                ProductId = po.Id,
                ReceivedQty = po.Quantity,
                Status = PurchaseOrderStatus.InProgress.ToString(),
                TotalAmount = po.Total,
                UnitPrice = po.UnitPrice,
                VendorId = long.Parse(ddlSupplier.SelectedValue),
                ReceivalDate = DateTime.UtcNow.AddDays(30),
                ShippingDate = DateTime.UtcNow.AddDays(5)

            }).ToList();

            try
            {
                string poNumber = poService.UpdateSave(listPo);

                if (!string.IsNullOrEmpty(poNumber))
                {
                    this.Master.LabelMessage = string.Format("Purchase Order Number: '{0}' Generated Successfully", poNumber);
                    poProducts.Clear();
                    Table2.DataSource = poProducts;
                    Table2.DataBind();

                    ddlSupplier.SelectedIndex = 0;
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                this.Master.LabelMessage = ex.ToString();
            }
        }

        private void FillPoGrid(long productId)
        {
            var productService = new PurchaseOrderService();
            long companyId = 2; //Session["CompanyId"]

            var listProduct = productService.GetProductByIdForPurchaseOrder(companyId, productId);

            var isExist = poProducts.Any(prd => prd.Id == productId);
            if (!isExist)
                poProducts.Add(listProduct.FirstOrDefault());

            Table2.DataSource = poProducts;
            Table2.DataBind();
        }

        protected void grdProductList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Buy")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                long id = long.Parse(grdProductList.DataKeys[index]["Id"].ToString());
                if (id > 0)
                    FillPoGrid(id);
            }
        }


        // Showing Grand Total on Footer Template
        protected void Table2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string total = ((Label)e.Row.FindControl("lblTotal")).Text;

                decimal totalvalue = Convert.ToDecimal(total);
                //e.Row.Cells[2].Text = totalvalue.ToString();
                sumFooterValue += totalvalue;
            }

            if (e.Row.RowType == DataControlRowType.Footer)
            {
                Label lbl = (Label)e.Row.FindControl("lblGrandTotal");
                lbl.Text = sumFooterValue.ToString();
            }
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            UpdateSave();
        }

        [WebMethod]
        public static string DeletePo(long id)
        {
            var deletableModel = poProducts.FirstOrDefault(prd => prd.Id == id);
            bool result = poProducts.Remove(deletableModel);

            if (result)
                return "Item Deleted";

            return "Error";
        }

        protected void btnLoadPO_Click(object sender, EventArgs e)
        {
            Table2.DataSource = poProducts;
            Table2.DataBind();
        }
    }
}