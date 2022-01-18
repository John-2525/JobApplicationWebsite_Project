using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Configuration.Entities
{
    public class ResumeSeedConfiguration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasData(
      new Resume
      {
          ResumeID = 1,
          Education = "123 secondary school",
          Certificates ="most handsome baker",
          Description = "Resume",
          UserID = 1,
          


      },
       new Resume
       {
           ResumeID = 2,
           Education = "temasek polytechinc",
           Certificates = "most handsum engineer",
           Description = "assistant engineer",
           UserID = 2,


       }





      );
        }
    }
}
