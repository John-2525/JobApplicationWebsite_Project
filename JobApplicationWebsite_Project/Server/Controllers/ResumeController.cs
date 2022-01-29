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
    [Route("/api/[controller]")]
    [ApiController]


    public class ResumesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResumesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Resumes
        [HttpGet]
        public async Task<IActionResult> GetResume()
        {
            var resume = await _unitOfWork.Resumes.GetAll();
            return Ok(resume);
        }

            // GET: api/Resumes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetResume(int id)
        {
            var resume = await _unitOfWork.Resumes.Get(q => q.Id == id);



            if (resume == null)
            {
                return NotFound();
            }

            return Ok(resume);
        }

        // PUT: api/Resumes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResume(int id, Resume resume)
        {
            if (id != resume.Id)
            {
                return BadRequest();
            }

            //_unitOfWork.Entry(resume).State = EntityState.Modified;
            _unitOfWork.Resumes.Update(resume);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ResumeExists(id))
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

        // POST: api/Resumes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Resume>> PostResume(Resume resume)
        {
            await _unitOfWork.Resumes.Insert(resume);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetResume", new { id = resume.Id }, resume);
        }

        // DELETE: api/Resumes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResume(int id)
        {
            var resume = await _unitOfWork.Resumes.Get(q => q.Id == id);
            if (resume == null)
            {
                return NotFound();
            }


            await _unitOfWork.Resumes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ResumeExists(int id)
        {
            var make = await _unitOfWork.Resumes.Get(q => q.Id == id);
            return make != null;
        }
    }
}
