using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class Resume : BaseDomainModel
    {

        [Required]
        public string Education { get; set; }
        [Required]
        public string School { get; set; }
        [Required]
        public string Certificates { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string User_Name{ get; set; }
        public virtual User User { get; set; }

    }
}
