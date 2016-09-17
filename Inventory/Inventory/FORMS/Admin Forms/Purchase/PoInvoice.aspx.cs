using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Utils;
using Service;

using Vm = Service.ViewModel;
using System.Web.UI.HtmlControls;
namespace Inventory.FORMS.Admin_Forms.Purchase
{
    public partial class PoInvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long companyId = 2;// long.Parse(Session["CompanyId"].ToString());
            var poService = new PurchaseOrderService();
            if (Request.QueryString["poNumber"] != null)
            {
                string poNumber = Request.QueryString["poNumber"];
                var invDetails = poService.PurchaseOrderSearchResult(companyId, poNumber).ToList();
                var htmlAsString = PopulateBody(invDetails);
                WriteHtml(htmlAsString);
                WriteHtml(invDetails);
            }
            
            //this.ActiveSideBarMenu();
        }

        protected void ActiveSideBarMenu()
        {
            HtmlGenericControl liInventorySetup = (HtmlGenericControl)Master.FindControl("liInventorySetup");
            liInventorySetup.Attributes.Add("class", "treeview active");
            HtmlGenericControl liPurchase = (HtmlGenericControl)Master.FindControl("liPurchase");
            liPurchase.Attributes.Add("class", "treeview active");
            HtmlGenericControl liPurchaseInvoice = (HtmlGenericControl)Master.FindControl("liPurchaseInvoice");
            liPurchaseInvoice.Attributes.Add("class", "active");
        }

        private IReadOnlyList<string> PopulateBody(List<Vm.PoInvoice> viewModels)
        {
            var templateReader = new TemplateReader();
            return templateReader.PopulateBody(viewModels);
        }

        private void WriteHtml(IReadOnlyList<string> htmlsAsString)
        {
            foreach (string htmlAsString in htmlsAsString)
                tbody.InnerHtml += htmlAsString;
        }

        private void WriteHtml(List<Vm.PoInvoice> viewModels)
        {
            var viewModel = viewModels.FirstOrDefault();
            var grandTotal = viewModels.Sum(vm => vm.GrandTotal);

            divInvDate.InnerHtml = Convert.ToString(string.Format("Date of Invoice: {0}", viewModel.InvDate));
            divPurchasedBy.InnerHtml = Convert.ToString(string.Format("Purchase by: {0}", viewModel.PurchasedBy));
            divSupplierAddress1.InnerHtml = viewModel.SupplierAddress;
            divsupplierEmail.InnerHtml = viewModel.SupplierEmail;
            divSupplierAddress2.InnerHtml = viewModel.SupplierAddress;
            divSupplierName.InnerHtml = viewModel.Vendor;
            poNumber.InnerHtml = string.Format("PO Number: {0}", viewModel.PoNumber);
            divSupplierPhone.InnerHtml = viewModel.SupplierPhone;
            tdSubTotal.InnerHtml = Convert.ToString("$ " + grandTotal);
            tdGrandTotal.InnerHtml = Convert.ToString("$ " + grandTotal);
        }
    }
}