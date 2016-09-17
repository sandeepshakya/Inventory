namespace Inventory.FORMS.Admin_Forms.Item.Attribute
{
    using Service;
    using System;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    public partial class AddAttribute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { //this.ActiveSideBarMenu();
            if (!Page.IsPostBack)
                FillProducts();
            this.ActiveSideBarMenu();
        }
         
    protected void ActiveSideBarMenu()
    {
        HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
        liInventorySetup.Attributes.Add("class", "treeview active");
        HtmlGenericControl liAAttribute = (HtmlGenericControl)Master.FindControl("liAAttribute");
        liAAttribute.Attributes.Add("class", "active");
            }

        private void FillProducts()
        {
            var productService = new ProductService();
            long companyId = 5; //long.Parse(Session["CompanyId"].ToString());
            var productList = productService.ProductListForDropDown(companyId);

            ddlProduct.DataSource = productList;
            ddlProduct.DataTextField = "Value";
            ddlProduct.DataValueField = "Key";
            ddlProduct.DataBind();

            ddlProduct.Items.Insert(0, "--Select--");

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var attribService = new ProductAttributeService();
            var model = new Model.Models.ProductAttribute();
            model.AttributeName = txtAttributeName.Value.Trim();
            bool isDuplicate = attribService.CheckDuplicate(model.AttributeName, ddlProduct.SelectedIndex > 0 ? long.Parse(ddlProduct.SelectedValue) : 0);

            if (isDuplicate)
            {
                this.Master.LabelMessage = string.Format("Attribute {0} Already Exists for Product {1}", model.AttributeName, ddlProduct.SelectedItem.Text);
                return;
            }
            try
            {
                model.ProductId = ddlProduct.SelectedIndex > 0 ? long.Parse(ddlProduct.SelectedValue) : 0;

                attribService.UpdateSave(model, 0);

                this.Master.LabelMessage = "Record Saved Successfully";

                txtAttributeName.Value = string.Empty;
                ddlProduct.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                this.Master.LabelMessage = "Error" + ex.ToString();
            }
        }
    }
}