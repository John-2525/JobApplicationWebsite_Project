using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasData(
           new User
           {
               UserID = 1,
               Name = "Lonk How Wank",
               Age = 23,
               Username = "username111",
               Password = "Password1",
               Address="126@gmail.com"



           },
            new User
            {
                UserID = 2,
                Name = "Ngiam Fabian",
                Age = 23,
                Username = "username222",
                Password = "Password2",
                Address = "127@gmail.com"



            });


        }
    }
}
