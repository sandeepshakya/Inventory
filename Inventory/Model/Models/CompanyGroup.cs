using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class CompanyGroup
    {
        public long Id { get; set; }
        public Nullable<long> CompanyId { get; set; }
        public string GroupName { get; set; }
        public string ReadList { get; set; }
        public string WriteList { get; set; }
        public string ModifyList { get; set; }
        public string ApprovalList { get; set; }
        public string UserIdList { get; set; }
        public string CurrentUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<CompanyGroup> CompanyGroupList { get; set; }
        public virtual CompanyGroup CompGroup { get; set; }
    }
}
