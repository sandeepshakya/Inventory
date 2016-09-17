using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

using ProductCategoryM = Model.Models.ProductCategory;
using System.Web.UI.HtmlControls;

namespace Inventory.FORMS.Admin_Forms.Item.Category
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActiveSideBarMenu();
        }

        protected void ActiveSideBarMenu()
        {
            ////Add
            HtmlGenericControl liAdd = (HtmlGenericControl)Master.FindControl("liAdd");
            liAdd.Attributes.Add("class", "active");
            HtmlAnchor anchorAdd = (HtmlAnchor)Master.FindControl("anchorAdd");
            anchorAdd.Attributes.Add("href", "~/FORMS/Admin Forms/Item/Category/Add.aspx");

            HtmlGenericControl span1 = (HtmlGenericControl)Master.FindControl("Span1");
            span1.Attributes.Add("class", "title");
            span1.InnerText = "Add Category";
            HtmlGenericControl Span2 = (HtmlGenericControl)Master.FindControl("Span2");
            Span2.Attributes.Add("class", "selected");

            ///Edit
            HtmlGenericControl liEdit = (HtmlGenericControl)Master.FindControl("liEdit");
            liEdit.Attributes.Add("class", "active");
            HtmlAnchor anchorEdit = (HtmlAnchor)Master.FindControl("anchorEdit");
            anchorEdit.Attributes.Add("href", "~/FORMS/Admin Forms/Item/Category/Edit.aspx");

            HtmlGenericControl span3 = (HtmlGenericControl)Master.FindControl("Span3");
            span3.Attributes.Add("class", "title");
            span3.InnerText = "Edit Category";
            HtmlGenericControl Span4 = (HtmlGenericControl)Master.FindControl("Span4");
            Span4.Attributes.Add("class", "selected");

            ////View
            HtmlGenericControl liView = (HtmlGenericControl)Master.FindControl("liView");
            liView.Attributes.Add("class", "active");
            HtmlAnchor anchorVew = (HtmlAnchor)Master.FindControl("anchorVew");
            anchorVew.Attributes.Add("href", "~/FORMS/Admin Forms/Item/Category/View.aspx");

            HtmlGenericControl span5 = (HtmlGenericControl)Master.FindControl("span5");
            span5.Attributes.Add("class", "title");
            span5.InnerText = "View Category";
            HtmlGenericControl Span6 = (HtmlGenericControl)Master.FindControl("Span6");
            Span6.Attributes.Add("class", "selected");


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

            model.Name = txtCategoryName.Value;
            model.CompanyId = 2;//long.Parse(Session["CompanyId"].ToString());

            model.UserName = "Shyam";// Session["username"].ToString();

            if (ddlCategoryName.SelectedIndex > 0)
            {
                try
                {
                    long response = catService.UpdateSave(model, long.Parse(ddlCategoryName.SelectedValue));
                    if (response > 0)
                    {
                        this.Master.LabelMessage = string.Format("Category {0} Updated Successfully.", ddlCategoryName.SelectedItem.Text);
                        GetCategoryList();
                        txtCategoryName.Value = string.Empty;
                        return;
                    }
                }
                catch (Exception ex)
                {
                   this.Master.LabelMessage = string.Format("Error Occurred.{0}", ex.ToString());
                }
            }
        }
    }
}