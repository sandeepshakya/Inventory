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

public partial class FORMS_System_Admin_Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["username"] == null)
        {
            Response.Redirect("~/FORMS/System Admin/SystemAdminLogin.aspx");
        }
        else
        {
            //Master.AddText = "Register Company";
            //lblMessage.Text = ""; 
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
        int Res;
        company ObjReg = new company();
        if (txtImageValid.Text == Session["strValidation"].ToString())
        {

            // Creating Object Of Class Company

            try
            {
                // Assigning Values To Properties of Company Class.

                ObjReg._company_Name = txtCompanyName.Value;
                ObjReg._companySize = int.Parse(txtSize.Value);
                ObjReg._contactPersonName = txtPerson.Value;
                ObjReg._companyDesc = txtDesc.Value;
                ObjReg._companyAddress = txtAddress.Value;
                ObjReg._city = txtCity.Value;
                ObjReg._state = txtState.Value;
                ObjReg._country = txtCountry.Value;
                ObjReg._companyContactNo = txtContactNo.Value;
                ObjReg._email = txtEmail.Value;
                ObjReg._website = txtUrl.Value;
                ObjReg._licence = int.Parse(txtLicence.Text);
                ObjReg._IsApplicable = true;
                ObjReg._IsImageExist = false;
                ObjReg._status = "Trial";

                ////Calling Function For Company Registration. 

                if (fuLogo.FileName != "")
                {
                    fuLogo.PostedFile.SaveAs(Server.MapPath("~/Images/" + txtCompanyName.Value + ".jpg "));
                }

                Res = ObjReg.InsertCompanyRegistration();
                if (Res == 0)
                {
                    lblErrMsg.Text = "Company Name Already Exist";
                    txtCompanyName.Value = "";

                }
                else
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



