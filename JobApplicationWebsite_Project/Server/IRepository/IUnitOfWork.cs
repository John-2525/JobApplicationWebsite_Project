using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationWebsite_Project.Shared.Domain;

namespace JobApplicationWebsite_Project.Server.IRespository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Company> Companies { get; }
        IGenericRepository<IndividSkills> Indivskills { get; }
        IGenericRepository<JobApplication> Jobapps { get; }
        IGenericRepository<JobPosting> Jobposts { get; }
        IGenericRepository<Resume> Resumes { get; }
        IGenericRepository<Review> Reviews { get; }

        IGenericRepository<SkillSet> Skillsets { get; }

        IGenericRepository<User> Users { get; }

    }
}