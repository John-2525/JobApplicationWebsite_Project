using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Configuration.Entities
{
    public class SkillSetSeedConfiguration : IEntityTypeConfiguration<SkillSet>
    {
        public void Configure(EntityTypeBuilder<SkillSet> builder)
        {
            builder.HasData(
        new SkillSet
        {
            SkillSetID = 1,
            PostingID = 1,
            IndividSkillsID = 1,
          


        },
         new SkillSet
         {
             SkillSetID = 2,
             PostingID = 2,
             IndividSkillsID = 2,



         });

        }
    }
}
