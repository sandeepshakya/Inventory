using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Service;

namespace Inventory.FORMS.Admin_Forms.Item.location
{
    public partial class AddLoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
                PopulateControls();
            }

            ActiveSideBarMenu();
        }

        private void HeaderSetting()
        {
            grdLoc.UseAccessibleHeader = true;
            grdLoc.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liWareHouse = (HtmlGenericControl)Master.FindControl("liWareHouse");
            liWareHouse.Attributes.Add("class", "treeview active");
            HtmlGenericControl liWhAdd = (HtmlGenericControl)Master.FindControl("liWhAdd");
            liWhAdd.Attributes.Add("class", "active");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            long id = 0;

            if (Request.QueryString["id"] != null)
                id = long.Parse(Request.QueryString["id"]);

            var service = new WareHouseLocationService();
            var model = new Model.Models.ProductLocation();
            model.Address = txtAddress.Value.Trim();
            model.Locaton = txtName.Value.Trim();

            bool isDuplicate = service.CheckDuplicate(model.Locaton, id);
            if (isDuplicate)
            {
                this.Master.LabelMessage = string.Format("Ware House '{0}' Already Exists", model.Locaton);
                return;
            }

            try
            {
                if (service.UpdateSave(model, id) > 0)
                {
                    this.Master.LabelMessage = string.Format("Ware House '{0}' Successfully Saved", model.Locaton);
                    BindGrid();
                    txtAddress.Value = string.Empty;
                    txtName.Value = string.Empty;
                }
            }
            catch (Exception ex)
            {
                this.Master.LabelMessage = string.Format("Error Occurred: {0}", ex.ToString());
            }
        }

        private void PopulateControls()
        {
            long id = 0;

            if (Request.QueryString["id"] != null)
            {
                id = long.Parse(Request.QueryString["id"]);

                var service = new WareHouseLocationService();

                var model = service.GetById(id);
                txtAddress.Value = model.Address;
                txtName.Value = model.Locaton;
            }
        }

        private void BindGrid()
        {
            var service = new WareHouseLocationService();
            grdLoc.DataSource = service.SearchResult();
            grdLoc.DataBind();
HeaderSetting();
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
                id = grdLoc.DataKeys[gr.RowIndex].Value.ToString();
                Sessions.InventorySessions.Current.Id = long.Parse(id);

                count = service.Delete(long.Parse(id));
                if (count > 0)
                {
                    this.Master.LabelMessage = string.Format("Warehouse Location Deleted Successfully.", "");
                    txtAddress.Value = string.Empty;
                    txtName.Value = string.Empty;
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