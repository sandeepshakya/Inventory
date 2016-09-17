using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    /// <summary>
    /// NOTE : This class is written Specific to Generate Product / Invoice / PO number generation.
    /// </summary>
    public class NumberRangeService : BaseNumberRangeService, INumberRangeService
    {
        public string GenerateRandomNumber(string type)
        {
            if (type == "Product")
                return base.NumberRange(000001, 99999);

            if (type == "PurchaseOrder")
                return base.NumberRange(0000010, 99999999);

            if (type == "SalesOrder")
                return base.NumberRange(10030410, 99999999);

            throw new ArgumentException("Number Range Does Not Work if No Module Type Is Provided");

        }
    }
}
