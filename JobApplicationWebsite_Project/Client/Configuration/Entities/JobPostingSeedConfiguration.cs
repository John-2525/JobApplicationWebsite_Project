using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Configuration.Entities
{
    public class JobPostingSeedConfiguration : IEntityTypeConfiguration<JobPosting>
    {
        public void Configure(EntityTypeBuilder<JobPosting> builder)
        {
            builder.HasData(
                new JobPosting
                {
                    JobPostingID = 1,
                    NumberOfYears = 2,
                    Salary =3000,
                    Position = "assistant baker",
                    Benefits = "paid toilet break every hour",
                    

                },
                 new JobPosting
                {
                    JobPostingID = 2,
                    NumberOfYears = 2,
                    Salary =4000,
                    Position = "assistant engineer",
                    Benefits = "free drink every hour",
                    

                }





                );

            
        }
    }
}
