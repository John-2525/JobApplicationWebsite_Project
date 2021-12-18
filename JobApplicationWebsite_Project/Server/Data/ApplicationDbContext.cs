using IdentityServer4.EntityFramework.Options;
using JobApplicationWebsite_Project.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationWebsite_Project.Shared.Domain;
using JobApplicationWebsite_Project.Client.Configuration.Entities;

namespace JobApplicationWebsite_Project.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Company> company { get; set; }

        public DbSet<IndividSkills> IndividSkills { get; set; }

        public DbSet<JobApplication> JobApplications { get; set; }

        public DbSet<JobPosting> JobPosting { get; set; }

        public DbSet<Resume> Resume { get; set; }

        public DbSet<Review> Review { get; set; }

        public DbSet<SkillSet> SkillSets { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new ResumeSeedConfiguration());

            builder.ApplyConfiguration(new ReviewSeedConfiguration());

            builder.ApplyConfiguration(new CompanySeedConfiguration());

            builder.ApplyConfiguration(new IndividSkillsSeedConfiguration());

            builder.ApplyConfiguration(new JobApplicationSeedConfiguration());

            builder.ApplyConfiguration(new JobPostingSeedConfiguration());

            builder.ApplyConfiguration(new SkillSetSeedConfiguration());
        }
    }

}
