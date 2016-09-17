namespace Inventory.FORMS.Admin_Forms.Item.Category
{
    using System;
    using System.Web.UI.HtmlControls;
    using Service;
    using System.Web.UI.WebControls;

    public partial class EditC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                BindGrid();

            this.ActiveSideBarMenu();
            HeaderSettings();
        }

        private void HeaderSettings()
        {
            grdCat.UseAccessibleHeader = true;
            grdCat.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liCategory = (HtmlGenericControl)Master.FindControl("liCategory");
            liCategory.Attributes.Add("class", "treeview active");
            HtmlGenericControl liECat = (HtmlGenericControl)Master.FindControl("liECat");
            liECat.Attributes.Add("class", "active");
        }

        private void BindGrid()
        {
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            var catgoryService = new CategoryService();
            grdCat.DataSource = catgoryService.GetCategoryList(companyId);
            grdCat.DataBind();

            HeaderSettings();
        }

        private void GetCategoryList()
        {
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            var categoryService = new CategoryService();

            ddlCategoryName.DataSource = categoryService.GetCategoryListForDropdown(companyId);
            ddlCategoryName.DataTextField = "value";
            ddlCategoryName.DataValueField = "key";
            ddlCategoryName.DataBind();

            ddlCategoryName.Items.Insert(0, "--Select--");
        }

        protected void ddlCategoryName_Init(object sender, EventArgs e)
        {
            GetCategoryList();
        }

        protected void ddlCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategoryName.SelectedIndex > 0)
            {
                var categoryService = new CategoryService();
                var model = categoryService.GetCategoryById(long.Parse(ddlCategoryName.SelectedValue));
                PopulateControls(model);
            }
        }

        private void PopulateControls(Model.Models.ProductCategory model)
        {
            txtCategoryName.Value = model.Name;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

            UpdateSave();
        }

        private void UpdateSave()
        {
            var catService = new CategoryService();

            var model = new Model.Models.ProductCategory();

            model.Name = txtCategoryName.Value.Trim();
            model.CompanyId = 2;//long.Parse(Session["CompanyId"].ToString());

            model.UserName = "Shyam";// Session["username"].ToString();

            bool isDuplicate = catService.CheckDuplicate(model.CompanyId, model.Name, long.Parse(ddlCategoryName.SelectedValue));
            if (isDuplicate)
            {
                this.Master.LabelMessage = string.Format("Category '{0}' Already Exists.", ddlCategoryName.SelectedItem.Text);
                return;
            }
            
            if (ddlCategoryName.SelectedIndex > 0)
            {
                try
                {
                    long response = catService.UpdateSave(model, long.Parse(ddlCategoryName.SelectedValue));
                    if (response > 0)
                    {
                        this.Master.LabelMessage = string.Format("Category '{0}' Updated Successfully.", ddlCategoryName.SelectedItem.Text);
                        GetCategoryList();
                        txtCategoryName.Value = string.Empty;
                        BindGrid();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    this.Master.LabelMessage = string.Format("Error Occurred.{0}", ex.ToString());
                }
            }
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
                id = grdCat.DataKeys[gr.RowIndex].Value.ToString();
                Sessions.InventorySessions.Current.Id = long.Parse(id);

                count = catgoryService.Delete(long.Parse(id));
                if (count > 0)
                {
                    this.Master.LabelMessage = string.Format("Category Deleted Successfully.", "");
                    txtCategoryName.Value = string.Empty;
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