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
        IGenericRepository<Company> companies { get; }
        IGenericRepository<IndividSkills> indivskills { get; }
        IGenericRepository<JobApplication> jobapps { get; }
        IGenericRepository<JobPosting> jobposts { get; }
        IGenericRepository<Resume> resumes { get; }
        IGenericRepository<Review> reviews { get; }

        IGenericRepository<SkillSet> skillsets{ get; }

        IGenericRepository<User> users { get; }

    }
}
