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
      Id = 1,
      CompanyName = "LGA TELECOM PTE LTD",
      Description = "As one of the industry’s digital pioneers, LGA has been helping shape Singapore’s digital ecosystem since 1995, starting first as a Digital Service Provider to now providing full digital solutions for businesses throughout Singapore.",
      PostingID = 1,
      HRStaffID = 1,
  },
  new Company
  {
      Id = 2,
      CompanyName = "ALVAS FOOD MANUFACTURE PTE LTD",
      Description = "ALVAS FOOD MANUFACTURE PTE. LTD. is located in Singapore, Singapore and is part of the Dairy Product Manufacturing Industry. ALVAS FOOD MANUFACTURE PTE. LTD. has 8 total employees across all of its locations. (Employees figure is modelled).",
      PostingID = 2,
      HRStaffID = 2,

  },
  new Company
  {
      Id = 3,
      CompanyName = "ADECCO PERSONNEL PTE LTD",
      Description = "For more than 35 years, Adecco provides a comprehensive array of HR solutions and consulting services which includes mid to staff level talentacquisition, contract recruitment, outsourcing, field sales and marketing as well as payroll services.Our expertise includes accounting & finance, admin & secretarial, banking, digital & eCommerce. ",
      PostingID = 3,
      HRStaffID = 3



  });
        }
    

    }

}
