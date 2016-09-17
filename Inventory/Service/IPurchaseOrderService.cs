using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PurchaseOrder = Model.Models.PurchaseOrder;
using Vm = Service.ViewModel;
namespace Service
{
    interface IPurchaseOrderService
    {
        string UpdateSave(List<PurchaseOrder> model);
        IReadOnlyList<Vm.PurchaseOrderProducts> GetProductByIdForPurchaseOrder(long companyId, long id);
        IReadOnlyList<Vm.PurchaseOrderSearchResult> PurchaseOrderSearchResult(long companyId);
        IReadOnlyList<Vm.PoInvoice> PurchaseOrderSearchResult(long companyId,string poNumber);
    }
}
