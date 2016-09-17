namespace Inventory.FORMS.Admin_Forms.Category
{
    using Service;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Reflection;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;


    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
               
                LoadCategory();
            
            this.ActiveSideBarMenu();
            this.HeaderSettings();
             }

        private void HeaderSettings()
        {
            grdCategory.UseAccessibleHeader = true;
            grdCategory.HeaderRow.TableSection = TableRowSection.TableHeader;
        }


        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liCategory = (HtmlGenericControl)Master.FindControl("liCategory");
            liCategory.Attributes.Add("class", "treeview active");
            HtmlGenericControl liVCat = (HtmlGenericControl)Master.FindControl("liVCat");
            liVCat.Attributes.Add("class", "active");
        }

        private void LoadCategory()
        {
            DataTable dt = new DataTable();
            long companyId = 2;//int.Parse(Session["CompanyId"].ToString());
            var catgoryService = new CategoryService();
                      grdCategory.DataSource = catgoryService.GetCategoryList(companyId); ;
            grdCategory.DataBind();
            
        }
        protected void LinkDeleteClick(object sender, EventArgs e)
        {
            try
            {
                var catgoryService = new CategoryService();

                int count = 0;
                LinkButton linkClicked = sender as LinkButton;
                GridViewRow gr = (GridViewRow)linkClicked.NamingContainer;
                string id = string.Empty;
                id = grdCategory.DataKeys[gr.RowIndex].Value.ToString();
                Sessions.InventorySessions.Current.Id = long.Parse(id);
count = catgoryService.Delete(long.Parse(id));
                if (count > 0)
                {
                   // this.Master.LabelMessage = string.Format("Category '{0}' Deleted Successfully.", "");
                                       Sessions.InventorySessions.Current.Id = 0;
                    this.LoadCategory();
                }
            }
            catch (Exception ex)
            {
                //Logger.WriteError("ERROR MESSAGE:" + ex.Message.ToString() + "STACK TRACE INFO:" + ex.StackTrace.ToString());
            }
        }

     
    }
}