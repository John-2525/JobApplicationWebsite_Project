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
            ReviewComment = "too good at baking",
            Rating = 3,
            UserID = 1,
            JobPostingID = 1,



        },
         new Review
         {
            Id=2,
             ReviewComment = "too good at computer",
             Rating = 4,
             UserID = 1,
             JobPostingID = 2,


         });


        }
    }
}
