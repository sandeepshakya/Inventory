using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;

using Service;

public partial class FORMS_Admin_Forms_Item_location_AddLocation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindGrid();
            PopulateControls();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        long id = 0;

        if (Request.QueryString["id"] != null)
            id = long.Parse(Request.QueryString["id"]);

        var service = new WareHouseLocationService();
        var model = new Model.Models.ProductLocation();
        model.Address = txtAddress.Value.Trim();
        model.Locaton = txtName.Value.Trim();

        bool isDuplicate = service.CheckDuplicate(model.Locaton, id);
        if (isDuplicate)
        {
            this.Master.LabelMessage = string.Format("Ware House '{0}' Already Exists", model.Locaton);
            return;
        }

        try
        {
            if (service.UpdateSave(model, id) > 0)
            {
                this.Master.LabelMessage = string.Format("Ware House '{0}' Successfully Saved", model.Locaton);
                BindGrid();
                txtAddress.Value = string.Empty;
                txtName.Value = string.Empty;
            }
        }
        catch (Exception ex)
        {
            this.Master.LabelMessage = string.Format("Error Occurred: {0}", ex.ToString());
        }
    }

    private void PopulateControls()
    {
        long id = 0;

        if (Request.QueryString["id"] != null)
            id = long.Parse(Request.QueryString["id"]);

        var service = new WareHouseLocationService();

        var model = service.GetById(id);
        txtAddress.Value = model.Address;
        txtName.Value = txtName.Value;
    }

    private void BindGrid()
    {
        var service = new WareHouseLocationService();
        grdLocation.DataSource = service.SearchResult();
        grdLocation.DataBind();
    }
}
