using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class JobApplication:BaseDomainModel
    {
      

        public String UserResume { get; set; }

        public String Comment { get; set; }

        public string User_Name { get; set; }

        public virtual User UserName { get; set; }

        public int JobPostingID { get; set; }

        public virtual JobPosting JobPosting { get; set; }

    





    }
}
