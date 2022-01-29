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


    public class IndivdSkillsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public IndivdSkillsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/IndivdSkills
        [HttpGet]


        // GET: api/IndivdSkills/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetIndivdSkill(int id)
        {
            var indivdskill = await _unitOfWork.Indivskills.Get(q => q.Id == id);



            if (indivdskill == null)
            {
                return NotFound();
            }

            return Ok(indivdskill);
        }

        // PUT: api/IndivdSkills/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndivdSkill(int id, IndividSkills indivdskill)
        {
            if (id != indivdskill.Id)
            {
                return BadRequest();
            }

            //_unitOfWork.Entry(indivdskill).State = EntityState.Modified;
            _unitOfWork.Indivskills.Update(indivdskill);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await IndivdSkillExists(id))
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

        // POST: api/IndivdSkills
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IndividSkills>> PostIndivdSkill(IndividSkills indivdskill)
        {
            await _unitOfWork.Indivskills.Insert(indivdskill);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetIndivdSkill", new { id = indivdskill.Id }, indivdskill);
        }

        // DELETE: api/IndivdSkills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndivdSkill(int id)
        {
            var indivdskill = await _unitOfWork.Indivskills.Get(q => q.Id == id);
            if (indivdskill == null)
            {
                return NotFound();
            }


            await _unitOfWork.Indivskills.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> IndivdSkillExists(int id)
        {
            var make = await _unitOfWork.Indivskills.Get(q => q.Id == id);
            return make != null;
        }
    }
}
