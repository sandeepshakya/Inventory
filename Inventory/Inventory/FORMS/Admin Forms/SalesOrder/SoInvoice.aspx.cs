using Inventory.Utils;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Inventory.FORMS.Admin_Forms.SalesOrder
{
    public partial class Invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //long companyId = 2;// long.Parse(Session["CompanyId"].ToString());
            var soService = new SalesOrderService();
            if (Request.QueryString["soNumber"] != null)
            {
                string soNumber = Request.QueryString["soNumber"];
                string poNumber = Request.QueryString["poNumber"];
                var invDetails = soService.Invoice(soNumber, poNumber).ToList();
                var htmlAsString = PopulateBody(invDetails);
                WriteHtml(htmlAsString);
                WriteHtml(invDetails);
            }
        }

        private IReadOnlyList<string> PopulateBody(List<Service.ViewModel.SoInvoice> viewModels)
        {
            var templateReader = new SalesOrderTemplate();
            return templateReader.PopulateBody(viewModels);
        }

        private void WriteHtml(IReadOnlyList<string> htmlsAsString)
        {
            foreach (string htmlAsString in htmlsAsString)
                tbody.InnerHtml += htmlAsString;
        }

        private void WriteHtml(List<Service.ViewModel.SoInvoice> viewModels)
        {
            var viewModel = viewModels.FirstOrDefault();
            var grandTotal = viewModels.Sum(vm => vm.GrandTotal);

            divInvDate.InnerHtml = Convert.ToString(string.Format("Date of Invoice: {0}", viewModel.InvDate));
            divPurchasedBy.InnerHtml = Convert.ToString(string.Format("Purchased by: {0}", viewModel.PurchasedBy));
            divSupplierAddress1.InnerHtml = viewModel.ShippingAddress;
            divsupplierEmail.InnerHtml = viewModel.SupplierEmail;
            divSupplierAddress2.InnerHtml = viewModel.ShippingAddress;
            divSupplierName.InnerHtml = viewModel.Name;
            soNumber.InnerHtml = string.Format("SO Number: {0}", viewModel.SoNumber);
            divSupplierPhone.InnerHtml = viewModel.SupplierPhone;
            tdSubTotal.InnerHtml = Convert.ToString("$ " + grandTotal);
            tdGrandTotal.InnerHtml = Convert.ToString("$ " + grandTotal);
        }
    }
}