using Inventory.EmailProvider;
using Service;
using System;
using System.Configuration;
using System.Net.Mail;

namespace Inventory.FORMS
{
    public partial class CompanyRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string SystemAdminEmailId = new MailAddress(ConfigurationManager.AppSettings["SystemAdmin"]).ToString();
            var companyService = new CompanyService();
            var model = new Model.Models.Company();
            long id = 0;
            if (Request.QueryString["id"] != null)
                id = long.Parse(Request.QueryString["id"]);

            if (companyService.CheckDuplicate(txtCompanyName.Value.Trim(), id))
            {
                lblMsg.Text = string.Format("Company '{0}' already exists", txtCompanyName.Value);
                return;
            }

            model.Name = txtCompanyName.Value;
            model.Size = int.Parse(txtSize.Value);
            model.PrimaryContactName = txtPerson.Value;
            model.Desc = txtDesc.Value;
            model.Address = txtAddress.Value;
            model.City = txtCity.Value;
            model.State = txtState.Value;
            model.Country = txtCountry.Value;
            model.ContactNo = txtContactNo.Value;
            model.Email = txtEmail.Value;
            model.Website = txtUrl.Value;

            long result = companyService.UpdateSave(model, 0);
            if (result > 0)
                //Email to person who is registererd with IMS
                EmailHelper.SendEmail(txtEmail.Value, EmailTemplateProvider.PopulateBody(txtCompanyName.Value, "signup", string.Empty), "Welcome To IMs");
            //Email to systemadminstrator for review
            EmailHelper.SendEmail(SystemAdminEmailId, EmailTemplateProvider.PopulateBody(txtCompanyName.Value, "systemadminreview", string.Empty, txtPerson.Value, txtEmail.Value, txtContactNo.Value), "Company Registered with IMs-Review");

            lblMsg.Text = string.Format("Company '{0}' is registered successfully", txtCompanyName.Value);
        }
    }
}