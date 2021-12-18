﻿using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Configuration.Entities
{
    public class IndividSkillsSeedConfiguration : IEntityTypeConfiguration<IndividSkills>
    {
        public void Configure(EntityTypeBuilder<IndividSkills> builder)
        {
            builder.HasData(
            new IndividSkills
            {
                IndividSkillsID = 1,
                SkillName = "baking",
                YearsofExperience = 3,
                Mastery = "novice"
            },
             new IndividSkills
             {
                 IndividSkillsID = 2,
                 SkillName = "Fixing",
                 YearsofExperience = 10,
                 Mastery = "expert"
             });

        }
    }
    }
