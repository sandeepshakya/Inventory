using Service;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
namespace Inventory.FORMS.Admin_Forms.Item.SubCategory
{
    public partial class AddSub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                BindGrid();
                FillDropDownList();
                PopulateControls();
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

            HtmlGenericControl liASubCategory = (HtmlGenericControl)Master.FindControl("liASubCategory");
            liASubCategory.Attributes.Add("class", "active");
        }

        private void BindGrid()
        {
            var subCatService = new SubCategoryService();
            grdSub.DataSource = subCatService.SubCategorySearchResult();
            grdSub.DataBind();

            HeaderSetting();
        }

        private void FillDropDownList()
        {
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            PopulateDropDownList.FillCategory(ddlCategory, companyId);
        }

        private void PopulateControls()
        {
            if (Request.QueryString["id"] != null)
            {
                var subcategoryService = new SubCategoryService();
                var model = subcategoryService.GetSubCategoryById(long.Parse(Request.QueryString["id"].ToString()));
                ddlCategory.SelectedValue = model.CategoryId.ToString();
                txtSubCat.Value = model.Name;
                ddlCategory.Enabled = false;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            long id = 0;
            if (Request.QueryString["id"] != null)
                id = long.Parse(Request.QueryString["id"]);

            var subcategoryService = new SubCategoryService();
            var model = new Model.Models.SubCategory();

            bool isDuplicate = subcategoryService.CheckDuplicate(txtSubCat.Value.Trim(),
                ddlCategory.SelectedIndex > 0 ? long.Parse(ddlCategory.SelectedValue)
                : 0, id);

            if (isDuplicate)
            {
                this.Master.LabelMessage = string.Format("Sub Category '{0}' Is Already Exists For Category '{1}'", txtSubCat.Value.Trim(), ddlCategory.SelectedItem.Text);
                return;
            }

            model.CategoryId = ddlCategory.SelectedIndex > 0 ? long.Parse(ddlCategory.SelectedValue) : 0;
            model.Name = txtSubCat.Value.Trim();
            try
            {
                long result = subcategoryService.UpdateSave(model, id);
                if (result > 0) { }
                this.Master.LabelMessage = string.Format("Sub Category '{0}' Successfully Saved ", txtSubCat.Value.Trim());
                //Response.Redirect("~/Forms/Admin Forms/Item/SubCategory/View.aspx");

            }
            catch (Exception ex)
            {
                this.Master.LabelMessage = "Error: " + ex.ToString();
            }

            ddlCategory.SelectedIndex = 0;
            txtSubCat.Value = string.Empty;
            BindGrid();
        }

        protected void LinkDeleteClick(object sender, EventArgs e)
        {
            try
            {
                var subcatgoryService = new SubCategoryService();

                int count = 0;
                LinkButton linkClicked = sender as LinkButton;
                GridViewRow gr = (GridViewRow)linkClicked.NamingContainer;
                string id = string.Empty;
                id = grdSub.DataKeys[gr.RowIndex].Value.ToString();
                Sessions.InventorySessions.Current.Id = long.Parse(id);

                count = subcatgoryService.Delete(long.Parse(id));
                if (count > 0)
                {
                    this.Master.LabelMessage = string.Format("SubCategory Deleted Successfully.", "");
                    txtSubCat.Value = string.Empty;
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