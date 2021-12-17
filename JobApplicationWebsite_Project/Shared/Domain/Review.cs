using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string  UserReview { get; set; }

        public string Description { get; set; }

        public int Rating { get; set; }

        public int SeekerID { get; set; }

        public int PostingID { get; set; }

    }
}
