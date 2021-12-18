using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class JobApplication
    {
        public int JobApplicationID { get; set; }

        public String UserResume { get; set; }

        public String Comment { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }

        public int JobPostingID { get; set; }

        public virtual JobPosting JobPosting { get; set; }

        public int ResumeID { get; set; }

        public virtual Resume Resume { get; set; }





    }
}
