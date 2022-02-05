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
                    Id=1,
                    NumberOfYears = 2,
                    Salary =2500,
                    Position = "Digital Media Production Assistant",
                    Responsibility = "Assist with all social media department logistics such as platform scheduling, copywriting, content calendar reviews, and posting support.Assist with production of social content shoots  including being on - set for photo and video shoots supporting where necessary" ,
                    Benefits = "Health Insurance , Paid time off , Life inusrance"
                    

                },
                 new JobPosting
                {
                    Id=2,
                    NumberOfYears = 2,
                    Salary =2800,
                    Position = "Office Administrator",
                    Responsibility= "Independently run the office space on a day-to-day basis to ensure smooth operations,Attend to incoming calls via the main phone line via a mobile application ,Liaise with appointed vendors and building management to perform regular routine office ",
                    Benefits = "Mental Health Benfits , Flexible work arrangements",
                    

                },
                 new JobPosting
                 {
                     Id=3,
                     NumberOfYears=3,
                     Salary =2600,
                     Position = "Delivery Driver",
                     Responsibility = "Loading up and counting of stocks before going out for delivery and counting balance of stocks when deliveries are done, place balance of stocks back intofactory's chillers at the end of the day. Main delivery route will be to NTUC and Giant outlets." ,
                     Benefits = ""
                 }





                );

            
        }
    }
}
