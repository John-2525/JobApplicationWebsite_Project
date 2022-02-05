using CarRentalManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class Resume : BaseDomainModel
    {
     

        public string Education { get; set; }

        public string School { get; set; }

        public string Certificates { get; set; }

        public string Description { get; set; }

        public string User_Name { get; set; }

        public virtual User UserName { get; set; }

    }
}
