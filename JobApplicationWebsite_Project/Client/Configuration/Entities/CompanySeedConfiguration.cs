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
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"
  },
  new Company
  {
      Id = 2,
      CompanyName = "ALVAS FOOD MANUFACTURE PTE LTD",
      Description = "ALVAS FOOD MANUFACTURE PTE. LTD. is located in Singapore, Singapore and is part of the Dairy Product Manufacturing Industry. ALVAS FOOD MANUFACTURE PTE. LTD. has 8 total employees across all of its locations. (Employees figure is modelled).",
      PostingID = 2,
      HRStaffID = 2,
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"

  },
  new Company
  {
      Id = 3,
      CompanyName = "ADECCO PERSONNEL PTE LTD",
      Description = "For more than 35 years, Adecco provides a comprehensive array of HR solutions and consulting services which includes mid to staff level talentacquisition, contract recruitment, outsourcing, field sales and marketing as well as payroll services.Our expertise includes accounting & finance, admin & secretarial, banking, digital & eCommerce. ",
      PostingID = 3,
      HRStaffID = 3,
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"



  },
  new Company
  {
      Id=4,
      CompanyName= "Popular Holdings",
      Description = "Popular Holdings Limited, more commonly known as just Popular or colloquially as the Popular Bookstore, is a Singaporean multinational bookstore chain. Aside from Singapore, it also has subsidiaries in countries such as Canada, China, Malaysia and the United Kingdom.",
      PostingID = 4,
      HRStaffID = 4,
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"
  },

  new Company
  {
      Id=5,
      CompanyName = "Spotify",
      Description = "Spotify is a Swedish audio streaming and media services provider founded on 23 April 2006 by Daniel Ek and Martin Lorentzon. It is one of the largest music streaming service providers with over 406 million monthly active users, including 180 million paying subscribers, as of December 2021",
      PostingID = 5,
      HRStaffID = 5,
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"

  },
  new Company
  {
      Id = 6 ,
      CompanyName = "Daiso",
      Description = "Daiso Industries Co., Ltd. is a large franchise of 100-yen shops founded in Japan. The headquarters are in Higashihiroshima, Hiroshima Prefecture. Daiso has a range of over 100,000 products, of which over 40 percent are imported goods, many of them from China, South Korea, and Japan.",
      PostingID = 6,
      HRStaffID = 6,
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"

  }

  );
        }
    

    }

}
