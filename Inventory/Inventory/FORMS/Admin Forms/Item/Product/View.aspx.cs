using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using System.Web.UI.HtmlControls;

namespace Inventory.FORMS.Admin_Forms.Item.Product
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                BindGrid();

            this.ActiveSideBarMenu();
            grdViewProduct.UseAccessibleHeader = true;
            grdViewProduct.HeaderRow.TableSection = TableRowSection.TableHeader;

        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liProduct = (HtmlGenericControl)Master.FindControl("liProduct");
            liProduct.Attributes.Add("class", "treeview active");

            HtmlGenericControl liVProduct = (HtmlGenericControl)Master.FindControl("liVProduct");
            liVProduct.Attributes.Add("class", "active");
        }


        private void BindGrid()
        {
            var productService = new ProductService();
            long companyId = 2; //Session["CompanyId"];
            var result = productService.GetProductList(companyId);
            grdViewProduct.DataSource = result;
            grdViewProduct.DataBind();
            // grdViewProduct.UseAccessibleHeader = true;
            //grdViewProduct.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void grdViewProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdViewProduct.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void grdViewProduct_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                long id = long.Parse(grdViewProduct.DataKeys[index]["Id"].ToString());
                Response.Redirect("~/Forms/Admin Forms/Item/Product/Add.aspx?id=" + id);
            }
        }

        protected void LinkDeleteClick(object sender, EventArgs e)
        {
            try
            {
                var productService = new ProductService();
                int count = 0;
                LinkButton linkClicked = sender as LinkButton;
                GridViewRow gr = (GridViewRow)linkClicked.NamingContainer;
                string id = string.Empty;
                id = grdViewProduct.DataKeys[gr.RowIndex].Value.ToString();
                Sessions.InventorySessions.Current.Id = long.Parse(id);
                count = productService.Delete(long.Parse(id));
                if (count > 0)
                {
                    this.Master.LabelMessage = string.Format("Products Deleted Successfully.", "");
                    this.BindGrid();
                    Sessions.InventorySessions.Current.Id = 0;
                }
            }
            catch (Exception ex)
            {
                //Logger.WriteError("ERROR MESSAGE:" + ex.Message.ToString() + "STACK TRACE INFO:" + ex.StackTrace.ToString());
            }
        }
    }
}