using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class IndividSkills:BaseDomainModel
    {
        

        public string SkillName { get; set; }

        public int YearsofExperience { get; set; }

        public string Mastery { get; set; }
    }
}
