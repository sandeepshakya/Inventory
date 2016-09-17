using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;

using Service;

public partial class FORMS_Admin_Forms_Item_location_ViewLocation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            BindGrid();
    }

    private void BindGrid()
    {
        var service = new WareHouseLocationService();
        grd.DataSource = service.SearchResult();
        grd.DataBind();
    }
    protected void grdViewLoc_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditButton")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            long id = long.Parse(grd.DataKeys[index]["Id"].ToString());
            Response.Redirect("~/Forms/Admin Forms/Item/Location/AddLocation.aspx?id=" + id);
        }
    }
}
