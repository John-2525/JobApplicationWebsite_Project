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


    public class JobAppsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobAppsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/JobApps
        [HttpGet]


        // GET: api/JobApps/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobApp(int id)
        {
            var jobapp = await _unitOfWork.Jobapps.Get(q => q.Id == id);



            if (jobapp == null)
            {
                return NotFound();
            }

            return Ok(jobapp);
        }

        // PUT: api/JobApps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobApp(int id, JobApplication jobapp)
        {
            if (id != jobapp.Id)
            {
                return BadRequest();
            }

            //_unitOfWork.Entry(jobapp).State = EntityState.Modified;
            _unitOfWork.Jobapps.Update(jobapp);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await JobAppExists(id))
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

        // POST: api/JobApps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobApplication>> PostJobApp(JobApplication jobapp)
        {
            await _unitOfWork.Jobapps.Insert(jobapp);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetJobApp", new { id = jobapp.Id }, jobapp);
        }

        // DELETE: api/JobApps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobApp(int id)
        {
            var jobapp = await _unitOfWork.Jobapps.Get(q => q.Id == id);
            if (jobapp == null)
            {
                return NotFound();
            }


            await _unitOfWork.Jobapps.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> JobAppExists(int id)
        {
            var make = await _unitOfWork.Jobapps.Get(q => q.Id == id);
            return make != null;
        }
    }
}
