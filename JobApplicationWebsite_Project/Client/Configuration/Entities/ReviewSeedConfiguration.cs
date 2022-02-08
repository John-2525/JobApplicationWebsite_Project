using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Configuration.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
        new Review
        {
            Id = 1,
            ReviewComment = "As soon as COVID-19 was getting serious, Indeed was one of the first companies to implement a mandatory work-from-home policy. Our healthy and safety came first, and I felt so lucky our company had the opportunity to make that decision. Since the WFH policy, our CEO, COO, and SVP of HR have been INCREDIBLE with transparency, being here for us and communicating to us more than I've ever seen.",
            Rating = 3,
            User_Name = "Jim Jimson",
            JobPostingID = 1,
            DateCreated = DateTime.Now,
            DateUpdated = DateTime.Now,
            CreatedBy = "System",
            UpdatedBy = "System"



        },
         new Review
         {
             Id = 2,
             ReviewComment = "We have unlimited PTO, and we are encouraged to take it. 401K match up to 3%. Great healthcare plan. Our NYC office is beautiful with fully stocked drinks and snacks. There's a gym and multiple terraces.  We have company happy hours once a month and our holiday parties are OUTSTANDING. ",
             Rating = 4,
             User_Name = "Danial Bin Sulfian",
             JobPostingID = 2,
             DateCreated = DateTime.Now,
             DateUpdated = DateTime.Now,
             CreatedBy = "System",
             UpdatedBy = "System"


         },
           new Review
           {
               Id = 3,
               ReviewComment = "Management tries to be inclusive and they provide training to ensure that employees are inclusive as they go about their work. The work can be challenging, and depending on your department, employees get lots of support. ",
               Rating = 4,
               User_Name = "Yew Yong Chang",
               JobPostingID = 2,
               DateCreated = DateTime.Now,
               DateUpdated = DateTime.Now,
               CreatedBy = "System",
               UpdatedBy = "System"


           },
             new Review
             {
                 Id = 4,
                 ReviewComment = "Company tries to be inclusive and they provide training to ensure that employees are inclusive as they go about their work. The work can be challenging, and depending on your department, employees get lots of support. ",
                 Rating = 4,
                 User_Name = "Yew Yong Chang",
                 JobPostingID = 2,
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"


             },
              new Review
              {
                  Id = 5,
                  ReviewComment = "Since being remote the communication is horrible! If your supervisor doesn’t know, you will be lost! The other supervisors take forever to respond because they have their own team to help. Also the vibe, unless you are a TOP agent. They do NOT care about you.",
                  User_Name = "Yeo Chen Si",
                  Rating = 2,
                  JobPostingID = 2,
                  DateCreated = DateTime.Now,
                  DateUpdated = DateTime.Now,
                  CreatedBy = "System",
                  UpdatedBy = "System"


              }



         );


        }
    }
}
