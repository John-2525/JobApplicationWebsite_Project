using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class Resume
    {
        public int ResumeID { get; set; }

        public string Education { get; set; }

        public string School { get; set; }

        public string Certificates { get; set; }

        public string Description { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }

    }
}
