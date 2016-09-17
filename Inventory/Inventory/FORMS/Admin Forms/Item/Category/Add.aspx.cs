namespace Inventory.FORMS.Admin_Forms.Item.Category
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Service;
    using System.Data;
    using System.Web.UI.HtmlControls;
    public partial class Add : System.Web.UI.Page
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var catService = new CategoryService();
            var model = new Model.Models.ProductCategory();

            model.Name = txtName.Value.Trim();
            model.UserName = "Shyam"; //Session["username"].ToString();
            model.CompanyId = 2;//long.Parse(Session["CompanyId"].ToString());

            if (catService.CheckDuplicate(model.CompanyId, model.Name, 0))
            {
               // this.Master.LabelMessage = string.Format("Category {0} Already Exists.", model.Name);
                return;
            }

            catService.UpdateSave(model, 0);

            //this.Master.LabelMessage = "Record saved successfully";
            txtName.Value = string.Empty;
        }
    }
}
