namespace Inventory.FORMS.Admin_Forms.Item.Category
{
    using Service;
    using System;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;
    public partial class AddC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                LoadCategory();

            ActiveSideBarMenu();

            HederSettings();
        }

        private void HederSettings()
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
            HtmlGenericControl liACat = (HtmlGenericControl)Master.FindControl("liACat");
            liACat.Attributes.Add("class", "active");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var catService = new CategoryService();
            var model = new Model.Models.ProductCategory();

            long id = 0;
            if (Request.QueryString["id"] != null)
                id = long.Parse(Request.QueryString["id"]);

            model.Name = txtName.Value.Trim();
            model.UserName = "Priyanka"; //Session["username"].ToString();
            model.CompanyId = 2;//long.Parse(Session["CompanyId"].ToString());

            if (catService.CheckDuplicate(model.CompanyId, model.Name, id))
            {
                this.Master.LabelMessage = string.Format("Category '{0}' Already Exists.", model.Name);
                return;
            }

            catService.UpdateSave(model, 0);

            this.Master.LabelMessage = string.Format("Category '{0}' Saved Successfully.", model.Name);
            txtName.Value = string.Empty;
            LoadCategory();
        }

        private void LoadCategory()
        {
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            var catgoryService = new CategoryService();
grdCategory.DataSource = catgoryService.GetCategoryList(companyId);
            grdCategory.DataBind();
            HederSettings();
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
                    this.Master.LabelMessage = string.Format("Category Deleted Successfully.","");
                    txtName.Value = string.Empty;
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