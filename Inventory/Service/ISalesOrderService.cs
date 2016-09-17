using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Service.ViewModel;
using SalesOrder = Model.Models.SalesOrder;

namespace Service
{
    interface ISalesOrderService
    {
        void UpdateSave(SalesOrder model, InventoryContext dbCntxt);
        IReadOnlyCollection<ViewModel.SalesOrderProducts> SearchResult(string poNumber);
        IReadOnlyList<SalesOrderList> GetSalesOrderForDropDownList();
        string IssueOrder(SalesOrder model, List<SalesOrderProducts> salesProducts);
        IReadOnlyCollection<SalesOrderProducts> SearchResult(long companyId);
        //ICollection<SalesOrderProducts> SearchResultByVendor(long vendorId);
        IReadOnlyCollection<SoInvoice> Invoice(string soNumber, string poNumber);
        IReadOnlyCollection<SalesOrder> GetByNumber(string soNumber);
    }
}
