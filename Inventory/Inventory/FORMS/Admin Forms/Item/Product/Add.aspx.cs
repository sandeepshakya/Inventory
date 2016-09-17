using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using System.Web.UI.HtmlControls;

namespace Inventory.FORMS.Admin_Forms.Item.Product
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillDropDownList();
                PopulateControls();
            }

            if (Request.QueryString["id"] != null)
            {
                ltrlTitle.Text = "Edit Product";
            }
            else
            {
                ltrlTitle.Text = "Add Product";
            }
            this.ActiveSideBarMenu();

        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liProduct = (HtmlGenericControl)Master.FindControl("liProduct");
            liProduct.Attributes.Add("class", "treeview active");

            HtmlGenericControl liAProduct = (HtmlGenericControl)Master.FindControl("liAProduct");
            liAProduct.Attributes.Add("class", "active");
        }

        private void FillDropDownList()
        {
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            PopulateDropDownList.FillCategory(ddlCat, companyId);
            PopulateDropDownList.FillWareHouse(ddlLocation);
        }

        protected void ddlCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDropDownList.FillSubCategory(ddlSubCat, ddlCat.SelectedIndex > 0 ? long.Parse(ddlCat.SelectedValue) : 0);
        }

        private void PopulateControls()
        {
            var productService = new ProductService();
            var subCatService = new SubCategoryService();

            var dbModel = new Model.Models.Product();
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            long id = 0;

            if (Request.QueryString["id"] != null)
                id = long.Parse(Request.QueryString["id"].ToString());

            if (id > 0)
            {
                PopulateDropDownList.FillCategory(ddlCat, companyId);

                dbModel = productService.GetProductById(id, companyId);
                ddlCat.SelectedValue = dbModel.CategoryId > 0 ? dbModel.CategoryId.ToString() : "0";
                PopulateDropDownList.FillSubCategory(ddlSubCat, dbModel.CategoryId);
                ddlLocation.SelectedValue = dbModel.LocationId > 0 ? dbModel.LocationId.ToString() : "0";
                ddlSubCat.SelectedValue = dbModel.SubCategoryId > 0 ? dbModel.SubCategoryId.ToString() : "0";

                txtDesc.Text = dbModel.ObjName;
                txtName.Text = dbModel.ProductName;
                txtNotifyBelowQntity.Value = dbModel.NotifyLowQuantity.ToString();
                txtPrice.Value = dbModel.ProductCost.ToString();
                txtQntity.Value = dbModel.Quantity.ToString();
            }
        }

        private void SaveUpdate()
        {
            long id = 0;
            if (Request.QueryString["id"] != null)
                id = long.Parse(Request.QueryString["id"]);

            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            var productService = new ProductService();
            var dbModel = new Model.Models.Product();
            string filename = string.Empty;

            if (ddlCat.SelectedIndex == 0 || ddlSubCat.SelectedIndex == 0 || ddlLocation.SelectedIndex == 0)
            {
                this.Master.LabelMessage = "Please Select Category / Sub Category / Warehouse Location";
                return;
            }

            if (productService.CheckDuplicate(long.Parse(ddlCat.SelectedValue), companyId, txtName.Text.Trim(), id))
            {
                this.Master.LabelMessage = string.Format("Product '{0}' Already Exists for selected Category '{1}'", txtName.Text.Trim(), ddlCat.SelectedItem.Text);
                return;
            }

            dbModel.ProductName = txtName.Text.Trim();
            dbModel.CategoryId = long.Parse(ddlCat.SelectedValue);
            dbModel.IsImageExist = flImageUploader.HasFile;
            dbModel.LocationId = long.Parse(ddlLocation.SelectedValue);
            dbModel.UserName = "Shyam"; //Session["username]";
            dbModel.ObjName = txtDesc.Text.Trim();
            dbModel.ProductCost = decimal.Parse(txtPrice.Value);
            dbModel.Quantity = int.Parse(txtQntity.Value);
            dbModel.NotifyLowQuantity = int.Parse(txtNotifyBelowQntity.Value);
            dbModel.CompanyId = companyId;
            dbModel.SubCategoryId = long.Parse(ddlSubCat.SelectedValue);
            filename = Path.GetFileName(flImageUploader.PostedFile.FileName);
            if (!string.IsNullOrEmpty(filename))
            {
                flImageUploader.SaveAs(Server.MapPath("~/Images/Product/" + filename));
                dbModel.ImageUrl = "~/Images/" + filename;
            }

            try
            {
                var result = productService.UpdateSave(dbModel, id);
                if (result > 0)
                    this.Master.LabelMessage = "Record Saved Successfully";
            }
            catch (Exception ex)
            {
                this.Master.LabelMessage = "Error: " + ex.InnerException.ToString();
            }
        }

        protected void Btn_AddProduct_Click(object sender, EventArgs e)
        {
            SaveUpdate();
        }
    }
}