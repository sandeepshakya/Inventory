using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Enums
{
    enum PurchaseOrderStatus
    {
        InProgress = 1,
        InTransit = 2,
        Delivered = 3,
        Cancelled = 4
    }
}