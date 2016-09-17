using Service;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.Admin_Forms.Item.SubCategory
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var subCatService = new SubCategoryService();
                grdSub.DataSource = subCatService.SubCategorySearchResult();
                grdSub.DataBind();
            }

            this.ActiveSideBarMenu();
            HeaderSetting();
        }

        private void HeaderSetting()
        {
            grdSub.UseAccessibleHeader = true;
            grdSub.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liSubCategory = (HtmlGenericControl)Master.FindControl("liSubCategory");
            liSubCategory.Attributes.Add("class", "treeview active");

            HtmlGenericControl liVSubCategory = (HtmlGenericControl)Master.FindControl("liVSubCategory");
            liVSubCategory.Attributes.Add("class", "active");
        }

        protected void grdSub_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                long id = long.Parse(grdSub.DataKeys[index]["Id"].ToString());
                Response.Redirect("~/Forms/Admin Forms/Item/SubCategory/AddSub.aspx?id=" + id);
            }
        }

        protected void LinkDeleteClick(object sender, EventArgs e)
        {
            try
            {
                var subCatService = new SubCategoryService();

                int count = 0;
                LinkButton linkClicked = sender as LinkButton;
                GridViewRow gr = (GridViewRow)linkClicked.NamingContainer;
                string id = string.Empty;
                id = grdSub.DataKeys[gr.RowIndex].Value.ToString();
                Sessions.InventorySessions.Current.Id = long.Parse(id);

                count = subCatService.Delete(long.Parse(id));
                if (count > 0)
                {
                  //  this.Master.LabelMessage = string.Format("SubCategory '{0}' Deleted Successfully.", "");
                   
                    Sessions.InventorySessions.Current.Id = 0;
                    //this.BindGrid();
                }
            }
            catch (Exception ex)
            {
                //Logger.WriteError("ERROR MESSAGE:" + ex.Message.ToString() + "STACK TRACE INFO:" + ex.StackTrace.ToString());
            }
        }

    }
}