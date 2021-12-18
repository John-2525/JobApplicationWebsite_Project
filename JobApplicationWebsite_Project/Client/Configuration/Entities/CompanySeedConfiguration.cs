using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Configuration.Entities
{
    public class CompanySeedConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
  new Company
  {
      CompanyID = 1,
      CompanyName = "Wank waffles",
      Description = "Wank sells the waffles",
      PostingID = 1,
      HRStaffID = 1,
  },
  new Company
  {
      CompanyID = 2,
      CompanyName = "Ngiam computah shop",
      Description = "Ngiam sells the computers",
      PostingID = 2,
      HRStaffID = 2,

  });
  

            }


        }
    }


