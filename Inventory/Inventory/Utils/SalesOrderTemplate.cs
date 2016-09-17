using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Service.ViewModel;

namespace Inventory.Utils
{
    public class SalesOrderTemplate
    {
        public virtual IReadOnlyList<string> PopulateBody(List<Service.ViewModel.SoInvoice> viewModels)
        {
            List<string> htmlAsString = new List<string>();
            string templateUrl = AppDomain.CurrentDomain.BaseDirectory + "InvoiceTemplates\\SalesOrder.html";
            try
            {
                foreach (var viewModel in viewModels)
                {
                    string body = string.Empty;
                    using (var reader = new StreamReader(templateUrl))
                    {
                        body = reader.ReadToEnd();
                    }

                    body = body.Replace("{InvDate}", viewModel.InvDate.ToString());
                    body = body.Replace("{PaymentMode}", viewModel.PaymentMode);
                    body = body.Replace("{OrderedQty}", viewModel.OrderedQty);
                    body = body.Replace("{ApprovedQty}", viewModel.ApprovedQty.Value.ToString());
                    body = body.Replace("{UnitPrice}", viewModel.UnitPrice.ToString());
                    body = body.Replace("{TotalPrice}", viewModel.TotalPrice.ToString());

                    htmlAsString.Add(body);
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }

            return htmlAsString;
        }

    }
}