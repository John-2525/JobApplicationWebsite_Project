using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class SkillSet: BaseDomainModel
    { 
       

        public int PostingID { get; set; }

        public virtual JobPosting JobPosting { get; set; }

        public int IndividSkillsID { get; set; }

        public virtual IndividSkills IndivSkills { get; set; }
    }
}
