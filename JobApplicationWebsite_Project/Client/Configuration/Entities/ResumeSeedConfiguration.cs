﻿using JobApplicationWebsite_Project.Shared.Domain;
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
         Id=1,
         User_Name="Luong Hao Wen",
          Education = "Degree of  BSc Digital Media ",
          School= "Singapore of Social Science",
          Certificates ="Profesional ceritication of professional Achievment in Digital Media",
          Description = ""

          
          ,
          


      },
       new Resume
       {
          Id=2,
           User_Name = "Dai Koi Yim",
           Education = "Diploma in Food Science",
           School = "Singapore Polytechnic",
           Certificates = "Food Hygiene certificate , MITx Manufacturing Program ",
           Description = ""
           ,


       },
       new Resume
       {
           Id=3,
           User_Name = "Danial bin Sulfian" , 
           Education= "Higher Nitec in Electronics" , 
           School = "ITE Central" ,
           Certificates = "Certificate of High Achievment in 3D modelling" ,
           Description = ""
       }





      );
        }
    }
}
