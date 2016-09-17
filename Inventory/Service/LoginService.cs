using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model.Models;

namespace Service
{
    public class LoginService : ILoginService
    {
        public bool Login(string userName, string password, string userType, string companyId)
        {
             long compId = long.Parse(companyId);

            if (string.IsNullOrEmpty(companyId))
                throw new ArgumentException("Company Id is Required");

            using (var dbCntxt = new InventoryContext())
            {
                if (companyId == "0") // If Super Admin then no companyId
                    return dbCntxt.SysAdmins
                    .Any(usr => usr.UserName == userName
                        && usr.Password == password
                        && usr.UserType == userType
                        );

                // If Not System Admin, then check CompanyId 
                 return dbCntxt.SysAdmins
                    .Any(usr => usr.UserName == userName 
                        && usr.Password == password 
                        && usr.UserType == userType
                        && usr.CompanyId.Value == compId);
            }
        }

        public SysAdmin GetLoginDetails(string userName, string password, string userType)
        {
            using (var dbCntxt = new InventoryContext())
            {
                // If Not System Admin, then check CompanyId 
                var result = dbCntxt.SysAdmins
                    .FirstOrDefault(usr => usr.UserName.ToLower() == userName.ToLower()
                        && usr.Password == password
                        && usr.UserType == userType);

                return result;
            }
        }
    }
}
