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
                    Id = 1,
                    NumberOfYears = 2,
                    NumberOfMonths = 3,
                    Salary = 2500,
                    Position = "Digital Media Production Assistant",
                    Responsiblity = "Assist with all social media department logistics such as platform scheduling, copywriting, content calendar reviews, and posting support.Assist with production of social content shoots  including being on - set for photo and video shoots supporting where necessary",
                    Benefits = "Health Insurance , Paid time off , Life inusrance",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"


                },
                 new JobPosting
                 {
                     Id = 2,
                     NumberOfYears = 2,
                     NumberOfMonths = 1,
                     Salary = 2800,
                     Position = "Office Administrator",
                     Responsiblity = "Independently run the office space on a day-to-day basis to ensure smooth operations,Attend to incoming calls via the main phone line via a mobile application ,Liaise with appointed vendors and building management to perform regular routine office ",
                     Benefits = "Mental Health Benfits , Flexible work arrangements",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"



                 },
                 new JobPosting
                 {
                     Id = 3,
                     NumberOfYears = 3,
                     NumberOfMonths = 0,
                     Salary = 2600,
                     Position = "Delivery Driver",
                     Responsiblity = "Loading up and counting of stocks before going out for delivery and counting balance of stocks when deliveries are done, place balance of stocks back intofactory's chillers at the end of the day. Main delivery route will be to NTUC and Giant outlets.",
                     Benefits = "Paid time off",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new JobPosting
                 {

                     Id = 4,
                     NumberOfYears = 2,
                     NumberOfMonths = 4,
                     Salary = 6000,
                     Position = "Sales & Marketing Executive",
                     Responsiblity = "Sales pitching, create awareness for prospect vie all possible avenue, Analysing of vehicle trends from all avenues, but not limited to, SGCM, personal social circle,Price monitoring/comparison from competitors and/or owners;",
                     Benefits = "Paid time off",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },

                 new JobPosting
                 {
                     Id=5,
                     NumberOfYears =3,
                     NumberOfMonths=0,
                     Salary=3500,
                     Position= "Accounts​/Senior Accounts Executive",
                     Responsiblity= "prepare the statement of accounts, balance sheet, reconciliations, preparing and posting of month end journals, processing payments and working closely with both internal and external stakeholders on accounting, reconciliation and treasury related matters.",
                     Benefits= "Health insurance.",
                     DateUpdated = DateTime.Now,
                     DateCreated= DateTime.Now

                 }





                );

            
        }
    }
}
