using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class GroupUser
    {
        public GroupUser()
        {
            this.GroupUsers1 = new List<GroupUser>();
        }

        public long Id { get; set; }
        public long GroupId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public long CompanyId { get; set; }
        public long DesigId { get; set; }
        public long DeptId { get; set; }
        public string UserType { get; set; }
        public string UserStatus { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string PresentAddress { get; set; }
        public string PresentCity { get; set; }
        public string PresentSate { get; set; }
        public string MobileNumber { get; set; }
        public string PermanentAddress { get; set; }
        public string PermanentCity { get; set; }
        public string PermanentState { get; set; }
        public string PermanentPhoneNumber { get; set; }
        public string PermanentMobileNumber { get; set; }
        public string SignaturePath { get; set; }
        public bool IsApplicable { get; set; }
        public string SubmittedBy { get; set; }
        public System.DateTime SubmissionDate { get; set; }
        public bool IsImageExist { get; set; }
        public virtual ICollection<GroupUser> GroupUsers1 { get; set; }
        public virtual GroupUser GroupUser1 { get; set; }
    }
}
