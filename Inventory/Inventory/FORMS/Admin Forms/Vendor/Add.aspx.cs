using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

using VendorM = Model.Models.Vendor;
namespace Inventory.FORMS.Admin_Forms.Vendor
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void UpdateSave()
        {
            long companyId = 2;//long.Parse(Session["CompanyId"].ToString());
            var vendorService = new VendorService();

            bool result = vendorService.CheckDuplicate(txtVendorName.Value.Trim(), companyId, 0);
            
            if (result)
            {
                this.Master.LabelMessage = string.Format("Vendor {0} Already Exists.", txtVendorName.Value.Trim());
                return;
            }

            var model = new VendorM();

            model.Address1 = txtVendorAddress1.Value;
            model.Address2 = txtVendorAddress2.Value;
            model.City = txtVendorCity.Value;
            model.Email = txtVendorEmail.Value;
            model.Fax = txtVendorFax.Value;
            model.IsApplicable = true;
            model.Mobile = txtVendorMobile.Value;
            model.Name = txtVendorName.Value;
            model.Office = txtVendorOffice.Value;
            model.Website = txtVendorWebsite.Value;
            model.UserName = Session["username"].ToString();
            model.CompanyId = companyId;

            try
            {
                long response = vendorService.UpdateSave(model, 0);
                if (response > 0)
                {
                    this.Master.LabelMessage = string.Format("Vendor {0} Added Successfully.", txtVendorName.Value.Trim());
                    return;
                }
            }
            catch (Exception ex)
            {
                this.Master.LabelMessage = string.Format("Error Occurred : {0}", ex.ToString());
            }
        }

        protected void btnSave_Click1(object sender, EventArgs e)
        {
            UpdateSave();
        }
    }
}