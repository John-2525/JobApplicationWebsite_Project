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
            Id=1,
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
            Id=2,
             ReviewComment = "We have unlimited PTO, and we are encouraged to take it. 401K match up to 3%. Great healthcare plan. Our NYC office is beautiful with fully stocked drinks and snacks. There's a gym and multiple terraces.  We have company happy hours once a month and our holiday parties are OUTSTANDING. ",
             Rating = 4,
             User_Name = "Danial Bin Sulfian",
             JobPostingID = 2,
             DateCreated = DateTime.Now,
             DateUpdated = DateTime.Now,
             CreatedBy = "System",
             UpdatedBy = "System"


         });


        }
    }
}
