using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;
using System.Web.UI.HtmlControls;

namespace Inventory.FORMS.Admin_Forms.Item.Attribute
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { this.ActiveSideBarMenu();
            if (!Page.IsPostBack)
                FillProducts();
        }

        
        protected void ActiveSideBarMenu()
        {
            ////Add
            HtmlGenericControl liAdd = (HtmlGenericControl)Master.FindControl("liAdd");
            liAdd.Attributes.Add("class", "active");
            HtmlAnchor anchorAdd = (HtmlAnchor)Master.FindControl("anchorAdd");
            anchorAdd.Attributes.Add("href", "~/FORMS/Admin Forms/Item/Attribute/Add.aspx");

            HtmlGenericControl span1 = (HtmlGenericControl)Master.FindControl("Span1");
            span1.Attributes.Add("class", "title");
            span1.InnerText = "Add Attribute";
            HtmlGenericControl Span2 = (HtmlGenericControl)Master.FindControl("Span2");
            Span2.Attributes.Add("class", "selected");

            ///Edit
            HtmlGenericControl liEdit = (HtmlGenericControl)Master.FindControl("liEdit");
            liEdit.Attributes.Add("class", "active");
            HtmlAnchor anchorEdit = (HtmlAnchor)Master.FindControl("anchorEdit");
            anchorEdit.Attributes.Add("href", "~/FORMS/Admin Forms/Item/Attribute/Edit.aspx");

            HtmlGenericControl span3 = (HtmlGenericControl)Master.FindControl("Span3");
            span3.Attributes.Add("class", "title");
            span3.InnerText = "Edit Attribute";
            HtmlGenericControl Span4 = (HtmlGenericControl)Master.FindControl("Span4");
            Span4.Attributes.Add("class", "selected");

            ////View
            HtmlGenericControl liView = (HtmlGenericControl)Master.FindControl("liView");
            liView.Attributes.Add("class", "active");
            HtmlAnchor anchorVew = (HtmlAnchor)Master.FindControl("anchorVew");
            anchorVew.Attributes.Add("href", "~/FORMS/Admin Forms/Item/Attribute/View.aspx");

            HtmlGenericControl span5 = (HtmlGenericControl)Master.FindControl("span5");
            span5.Attributes.Add("class", "title");
            span5.InnerText = "View Attribute";
            HtmlGenericControl Span6 = (HtmlGenericControl)Master.FindControl("Span6");
            Span6.Attributes.Add("class", "selected");


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
                //this.Master.LabelMessage = string.Format("Attribute {0} Already Exists for Product {1}", model.AttributeName, ddlProduct.SelectedItem.Text);
                return;
            }
            try
            {
                model.ProductId = ddlProduct.SelectedIndex > 0 ? long.Parse(ddlProduct.SelectedValue) : 0;

                attribService.UpdateSave(model, 0);

                //this.Master.LabelMessage = "Record Saved Successfully";

                txtAttributeName.Value = string.Empty;
                ddlProduct.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
               // this.Master.LabelMessage = "Error" + ex.ToString();
            }
        }
    }
}