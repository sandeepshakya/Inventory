using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModel
{
    public class Company
    {
        public long CompanyID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }

        public string ContactPersonName { get; set; }
       
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int NoOfLicence { get; set; }
        public DateTime ApprovalDate { get; set; }
        public int LicenceDuration { get; set; }
        public DateTime TrialStartDate { get; set; }
        public DateTime TrialEndDate { get; set; }

        public string Status { get; set; }
    }
}
