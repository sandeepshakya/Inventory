using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Service;

namespace Inventory.FORMS.System_Admin
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] == null)
            {
                Response.Redirect("~/FORMS/System Admin/SystemAdminLogin.aspx");
            }
            
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            long id = 0;
            if (Request.QueryString["id"] != null)
                id = long.Parse(Request.QueryString["id"]);

            if (txtImageValid.Text == Session["strValidation"].ToString())
            {
                try
                {
                    // Assigning Values To Properties of Company Class.
                    var companyService = new CompanyService();
                    var model = new Model.Models.Company();

                    if (companyService.CheckDuplicate(txtCompanyName.Value.Trim(), id))
                    {
                        lblErrMsg.Text = string.Format("Company '{0}' Name Already Exists", txtCompanyName.Value);
                        txtCompanyName.Value = "";
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
                    model.LicenceNo = int.Parse(txtLicence.Text);
                    model.IsApplicable = true;
                    model.IsImageExist = false;
                    model.Status = "Trial";

                    if (fuLogo.FileName != "")
                    {
                        model.Image = "~/Images/" + txtCompanyName.Value + ".jpg ";
                        fuLogo.PostedFile.SaveAs(Server.MapPath("~/Images/" + txtCompanyName.Value + ".jpg "));
                    }

                    long result = companyService.UpdateSave(model, 0);

                    if (result > 0)
                    {
                        lblErrMsg.Text = "Company Registered Sucessfully";
                        ClearField();

                    }

                }
                catch (Exception E)
                {
                    lblErrMsg.Text = E.Message.ToString();
                }
            }
            else
            {
                lblErrMsg.Text = "Invalid Image Sequence";
            }
        }

        public void ClearField()
        {
            txtCompanyName.Value = "";
            txtAddress.Value = "";
            txtCity.Value = "";
            txtContactNo.Value = "";
            txtCountry.Value = "";
            txtDesc.Value = "";
            txtEmail.Value = "";
            txtLicence.Text = "";
            txtPerson.Value = "";
            txtSize.Value = "";
            txtState.Value = "";
            txtUrl.Value = "";
            txtImageValid.Text = "";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

    }
}