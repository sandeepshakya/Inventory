using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

using VendorM = Model.Models.Vendor;
using System.Web.UI.HtmlControls;

namespace Inventory.FORMS.Admin_Forms.Vendor
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ActiveSideBarMenu();
        }


        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liVendor = (HtmlGenericControl)Master.FindControl("liVendor");
            liVendor.Attributes.Add("class", "treeview active");
            HtmlGenericControl liEVendor = (HtmlGenericControl)Master.FindControl("liEVendor");
            liEVendor.Attributes.Add("class", "active");
        }


        private void GetVendorList()
        {
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            var vendorService = new VendorService();

            ddlVendorName.DataSource = vendorService.GetVendorListForDropDown(companyId);
            ddlVendorName.DataTextField = "Value";
            ddlVendorName.DataValueField = "Key";
            ddlVendorName.DataBind();

            ddlVendorName.Items.Insert(0, "--Select--");
        }

        protected void ddlVendorName_Init(object sender, EventArgs e)
        {
            GetVendorList();
        }

        protected void ddlVendorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlVendorName.SelectedIndex > 0)
            {
                var vendorService = new VendorService();
                var model = vendorService.GetVendorById(long.Parse(ddlVendorName.SelectedValue));
                PopulateControls(model);
            }
        }

        private void PopulateControls(Model.Models.Vendor model)
        {
            txtVendorAddress1.Value = model.Address1;
            txtVendorAddress2.Value = model.Address2;
            txtVendorEmail.Value = model.Email;
            txtVendorMobile.Value = model.Mobile;
            txtVendorOffice.Value = model.Office;
            txtVendorWebsite.Value = model.Website;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateSave();
        }

        private void UpdateSave()
        {
            //long companyId = 2; //long.Parse(Session["CompanyId"].ToString());
            var vendorService = new VendorService();

            var model = new Model.Models.Vendor();

            model.Address1 = txtVendorAddress1.Value;
            model.Address2 = txtVendorAddress2.Value;
            model.Email = txtVendorEmail.Value;
            model.IsApplicable = true;
            model.Mobile = txtVendorMobile.Value;
            model.Office = txtVendorOffice.Value;
            model.Website = txtVendorWebsite.Value;
            model.UserName = "Shyam"; //Session["username"].ToString();

            if (ddlVendorName.SelectedIndex > 0)
            {
                try
                {
                    long response = vendorService.UpdateSave(model, long.Parse(ddlVendorName.SelectedValue));
                    if (response > 0)
                    {
                        this.Master.LabelMessage = string.Format("Vendor '{0}' Updated Successfully.", ddlVendorName.SelectedItem.Text);
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