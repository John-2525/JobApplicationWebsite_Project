﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Shared.Domain
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string ReviewComment { get; set; }

        public int Rating { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }

        public int JobPostingID { get; set; }

        public virtual JobPosting JobPosting { get; set; }

    }
}
