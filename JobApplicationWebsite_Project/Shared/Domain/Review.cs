using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class Review: BaseDomainModel
    {
        [Required]
        public string ReviewComment { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please Do Not Leave It Blank")]
        public int Rating { get; set; }
        [Required]
        public string User_Name { get; set; }

        public virtual User UserName { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Please Do Not Leave It Blank")]
        public int JobPostingID { get; set; }

        public virtual JobPosting JobPosting { get; set; }

    }
}
