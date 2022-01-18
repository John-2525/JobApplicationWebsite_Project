using CarRentalManagement.Shared;
using JobApplicationWebsite_Project.Server.Data;
using JobApplicationWebsite_Project.Server.IRespository;
using JobApplicationWebsite_Project.Server.Models;
using JobApplicationWebsite_Project.Shared;
using JobApplicationWebsite_Project.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace JobApplicationWebsite_Project.Server.Respository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Company> _companies;
        private IGenericRepository<IndividSkills> _indivskills;
        private IGenericRepository<JobApplication> _jobapps;
        private IGenericRepository<JobPosting> _jobposts;
        private IGenericRepository<Resume> _resumes;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<SkillSet> _skillsetss;
        private IGenericRepository<User> _users;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Company> companies
            => _companies ??= new GenericRepository<Company>(_context);
        public IGenericRepository<IndividSkills> indivskills
            => _indivskills ??= new GenericRepository<IndividSkills>(_context);
        public IGenericRepository<JobApplication> jobapps
            => _jobapps ??= new GenericRepository<JobApplication>(_context);
        public IGenericRepository<JobPosting> jobposts
            => _jobposts ??= new GenericRepository<JobPosting>(_context);
        public IGenericRepository<Resume> resumes
            => _resumes ??= new GenericRepository<Resume>(_context);
        public IGenericRepository<Review> reviews
            => _reviews ??= new GenericRepository<Review>(_context);

        public IGenericRepository<SkillSet> skillsets
            => _skillsetss ??= new GenericRepository<SkillSet>(_context);

        public IGenericRepository<User> users
            => _users ??= new GenericRepository<User>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }







}