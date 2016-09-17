using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Enums
{
    public enum SalesOrderStatus
    {
        InProgress = 1,
        Pending = 2,
        Issued = 3,
        Cancelled = 4,
        Shipped = 5
    }
}