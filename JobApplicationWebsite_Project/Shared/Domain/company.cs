using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class Company:BaseDomainModel
    {
       
        

        public string CompanyName { get; set; }

        public string Description { get; set; }

        public int? PostingID { get; set; }

        public virtual JobPosting JobPosting { get; set; }

        public int? HRStaffID { get; set; }
    }
}
