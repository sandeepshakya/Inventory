using Service;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.Admin_Forms.Vendor
{
    public partial class ViewVndr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                LoadVendor();
            this.ActiveSideBarMenu();
            HeaderSetting();
        }

        private void HeaderSetting()
        {
            grdVendor.UseAccessibleHeader = true;
            grdVendor.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liVendor = (HtmlGenericControl)Master.FindControl("liVendor");
            liVendor.Attributes.Add("class", "treeview active");
            HtmlGenericControl liVVendor = (HtmlGenericControl)Master.FindControl("liVVendor");
            liVVendor.Attributes.Add("class", "active");
        }

        protected void LinkDeleteClick(object sender, EventArgs e)
        {
            try
            {
                var vendorService = new VendorService();

                long count = 0;
                LinkButton linkClicked = sender as LinkButton;
                GridViewRow gr = (GridViewRow)linkClicked.NamingContainer;
                string id = string.Empty;
                id = grdVendor.DataKeys[gr.RowIndex].Value.ToString();
                Sessions.InventorySessions.Current.Id = long.Parse(id);
                count = vendorService.Delete(long.Parse(id));
                if (count > 0)
                {
                    this.Master.LabelMessage = string.Format("Vendor Deleted Successfully.", "");
                    Sessions.InventorySessions.Current.Id = 0;
                    this.LoadVendor();
                }
            }
            catch (Exception ex)
            {
                //Logger.WriteError("ERROR MESSAGE:" + ex.Message.ToString() + "STACK TRACE INFO:" + ex.StackTrace.ToString());
            }
        }


        private void LoadVendor()
        {
            long companyId =long.Parse(Session["CompanyId"].ToString());
            var vendorService = new VendorService();
            grdVendor.DataSource = vendorService.GetVendorList(companyId);
            grdVendor.DataBind();
            HeaderSetting();
        }
    }
}