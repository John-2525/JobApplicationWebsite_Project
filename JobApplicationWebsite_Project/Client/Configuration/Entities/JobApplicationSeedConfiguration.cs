﻿using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Configuration.Entities
{
    public class JobApplicationSeedConfiguration : IEntityTypeConfiguration<JobApplication>
    {
        public void Configure(EntityTypeBuilder<JobApplication> builder)
        {
            builder.HasData(
                 new JobApplication
                 {
                     Id=1,
                     UserResume = "Very good at baking mr wank",
                     Comment = "very good",
                     UserID = 1,
                     JobPostingID=1,


                 },
                  new JobApplication
                  {
                      Id=2,
                      UserResume = "Very good at comptur mr ngiam",
                      Comment = "very good",
                      UserID = 2,
                      JobPostingID = 2,


                  }
                );


        }
    }
}
