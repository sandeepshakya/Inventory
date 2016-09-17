using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Service.ViewModel;

namespace Inventory.Utils
{
    public class TemplateReader
    {
        public virtual IReadOnlyList<string> PopulateBody(List<PoInvoice> viewModels)
        {
            List<string> htmlAsString = new List<string>();
            string templateUrl = AppDomain.CurrentDomain.BaseDirectory + "InvoiceTemplates\\PurchaseOrder.html";
            try
            {
                foreach (var viewModel in viewModels)
                {
                    string body = string.Empty;
                    using (var reader = new StreamReader(templateUrl))
                    {
                        body = reader.ReadToEnd();
                    }

                    body = body.Replace("{SlNumber}", viewModel.SlNumber.ToString());
                    body = body.Replace("{Name}", viewModel.Name);
                    body = body.Replace("{UnitPrice}", viewModel.UnitPrice.ToString());
                    body = body.Replace("{Quantity}", viewModel.Quantity.ToString());
                    body = body.Replace("{GrandTotal}", viewModel.GrandTotal.ToString());

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