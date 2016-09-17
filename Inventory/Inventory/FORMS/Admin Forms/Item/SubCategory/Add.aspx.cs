using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

namespace Inventory.FORMS.Admin_Forms.Item.SubCategory
{
    public partial class SubCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                FillDropDownList();
        }


        private void FillDropDownList()
        {
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            PopulateDropDownList.FillCategory(ddlCategory, companyId);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var subcategoryService = new SubCategoryService();
            var model = new Model.Models.SubCategory();
            
            bool isDuplicate = subcategoryService.CheckDuplicate(txtSubCat.Value.Trim(),
                ddlCategory.SelectedIndex > 0 ? long.Parse(ddlCategory.SelectedValue)
                : 0);

            if (isDuplicate)
            {
                this.Master.LabelMessage = string.Format("Sub Category {0} Is Already Exists For Category {1}",txtSubCat.Value.Trim(), ddlCategory.SelectedItem.Text);
                return;
            }

            model.CategoryId = ddlCategory.SelectedIndex > 0 ? long.Parse(ddlCategory.SelectedValue) : 0;
            model.Name = txtSubCat.Value.Trim();
            try
            {
                long result = subcategoryService.UpdateSave(model, 0);
                if (result > 0)
                    this.Master.LabelMessage = "Record Saved Successfully";
            }
            catch (Exception ex)
            {
                this.Master.LabelMessage = "Error: " + ex.ToString();
            }

            ddlCategory.SelectedIndex = 0;
            txtSubCat.Value = string.Empty;
        }
    }
}