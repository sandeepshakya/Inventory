using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class SysAdmin
    {
        public long Id { get; set; }
        public Nullable<long> CompanyId { get; set; }
        public string Status { get; set; }
        public Nullable<int> NoofLicence { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string OperateType { get; set; }
        public string CompanyIdList { get; set; }
        public virtual SysAdmin SysAdmin1 { get; set; }
        public virtual SysAdmin SysAdmin2 { get; set; }
    }
}
