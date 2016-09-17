using Service;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.Admin_Forms.Item.location
{
    public partial class ViewLoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }

            ActiveSideBarMenu();
            grd.UseAccessibleHeader = true;
            grd.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liWareHouse = (HtmlGenericControl)Master.FindControl("liWareHouse");
            liWareHouse.Attributes.Add("class", "treeview active");
            HtmlGenericControl liWhView = (HtmlGenericControl)Master.FindControl("liWhView");
            liWhView.Attributes.Add("class", "active");
        }

        private void BindGrid()
        {
            var service = new WareHouseLocationService();
            grd.DataSource = service.SearchResult();
            grd.DataBind();
        }
        protected void grdViewLoc_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                long id = long.Parse(grd.DataKeys[index]["Id"].ToString());
                Response.Redirect("~/Forms/Admin Forms/Item/Location/AddLoc.aspx?id=" + id);
            }
        }

        protected void LinkDeleteClick(object sender, EventArgs e)
        {
            try
            {
                var service = new WareHouseLocationService();
                int count = 0;
                LinkButton linkClicked = sender as LinkButton;
                GridViewRow gr = (GridViewRow)linkClicked.NamingContainer;
                string id = string.Empty;
                id = grd.DataKeys[gr.RowIndex].Value.ToString();
                Sessions.InventorySessions.Current.Id = long.Parse(id);

                count = service.Delete(long.Parse(id));
                if (count > 0)
                {
                    this.Master.LabelMessage = string.Format("Warehouse Location Deleted Successfully.", "");
                    
                    Sessions.InventorySessions.Current.Id = 0;
                    this.BindGrid();
                }
            }
            catch (Exception ex)
            {
                //Logger.WriteError("ERROR MESSAGE:" + ex.Message.ToString() + "STACK TRACE INFO:" + ex.StackTrace.ToString());
            }
        }

    }
}