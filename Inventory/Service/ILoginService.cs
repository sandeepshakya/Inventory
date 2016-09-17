using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Service
{
    interface ILoginService
    {
        bool Login(string userName, string password, string userType, string companyId);
        SysAdmin GetLoginDetails(string userName, string password, string userType);
    }
}
