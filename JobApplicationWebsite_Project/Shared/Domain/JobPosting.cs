using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class JobPosting:BaseDomainModel
    {
        

        public int NumberOfYears { get; set; }

        public int Salary { get; set; }

        public string Position { get; set; }

        public string Benefits { get; set; }

    }
}
