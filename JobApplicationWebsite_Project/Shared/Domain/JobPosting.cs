using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class JobPosting:BaseDomainModel
    {
        
        [Required]
        [Range(1, 20, ErrorMessage = "Please Enter a Valid Employment Duration")]

        public int NumberOfYears { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "Please Enter a Valid Employment Duration")]
        public int NumberOfMonths { get; set; }

        [Required]
        [Range(double.Epsilon,double.MaxValue, ErrorMessage = "Please Do Not Leave It Blank")]
        public int Salary { get; set; }

        [Required]
        public string Position { get; set; }
        [Required]
        public string Benefits { get; set; }
        [Required]
        public string Responsiblity { get; set; }

    }
}
