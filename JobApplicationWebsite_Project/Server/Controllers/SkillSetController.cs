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


    public class SkillSetsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SkillSetsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/SkillSets
        [HttpGet]


        // GET: api/SkillSets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkillSet(int id)
        {
            var skillset = await _unitOfWork.Skillsets.Get(q => q.Id == id);



            if (skillset == null)
            {
                return NotFound();
            }

            return Ok(skillset);
        }

        // PUT: api/SkillSets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillSet(int id, SkillSet skillset)
        {
            if (id != skillset.Id)
            {
                return BadRequest();
            }

            //_unitOfWork.Entry(skillset).State = EntityState.Modified;
            _unitOfWork.Skillsets.Update(skillset);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SkillSetExists(id))
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

        // POST: api/SkillSets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SkillSet>> PostSkillSet(SkillSet skillset)
        {
            await _unitOfWork.Skillsets.Insert(skillset);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSkillSet", new { id = skillset.Id }, skillset);
        }

        // DELETE: api/SkillSets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillSet(int id)
        {
            var skillset = await _unitOfWork.Skillsets.Get(q => q.Id == id);
            if (skillset == null)
            {
                return NotFound();
            }


            await _unitOfWork.Skillsets.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SkillSetExists(int id)
        {
            var make = await _unitOfWork.Skillsets.Get(q => q.Id == id);
            return make != null;
        }
    }
}
