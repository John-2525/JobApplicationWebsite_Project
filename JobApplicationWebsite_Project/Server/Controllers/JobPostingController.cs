using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobApplicationWebsite_Project.Server.Data;
using JobApplicationWebsite_Project.Shared.Domain;
using JobApplicationWebsite_Project.Server.IRespository;
using JobApplicationWebsite_Project.Server.Respository;
using Microsoft.AspNetCore.Authorization;

namespace JobApplicationWebsite_Project.Server.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]


    public class JobPostingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobPostingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/JobPostings
        [HttpGet]


        // GET: api/JobPostings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobPosting(int id)
        {
            var jobposting = await _unitOfWork.Jobposts.Get(q => q.Id == id);



            if (jobposting == null)
            {
                return NotFound();
            }

            return Ok(jobposting);
        }

        // PUT: api/JobPostings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobPosting(int id, JobPosting jobposting)
        {
            if (id != jobposting.Id)
            {
                return BadRequest();
            }

            //_unitOfWork.Entry(jobposting).State = EntityState.Modified;
            _unitOfWork.Jobposts.Update(jobposting);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await JobPostingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/JobPostings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobPosting>> PostJobPosting(JobPosting jobposting)
        {
            await _unitOfWork.Jobposts.Insert(jobposting);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetJobPosting", new { id = jobposting.Id }, jobposting);
        }

        // DELETE: api/JobPostings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobPosting(int id)
        {
            var jobposting = await _unitOfWork.Jobposts.Get(q => q.Id == id);
            if (jobposting == null)
            {
                return NotFound();
            }


            await _unitOfWork.Jobposts.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> JobPostingExists(int id)
        {
            var make = await _unitOfWork.Jobposts.Get(q => q.Id == id);
            return make != null;
        }
    }
}
