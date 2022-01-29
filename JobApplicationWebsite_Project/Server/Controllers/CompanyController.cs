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


    public class CompanysController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanysController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Companys
        [HttpGet]
        public async Task<ActionResult<Company>> GetCompany()
        {
            var companies = await _unitOfWork.Companies.GetAll();

            return Ok(companies);
        }

        // GET: api/Companys/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);



            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        // PUT: api/Companys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            if (id != company.Id)
            {
                return BadRequest();
            }

            //_unitOfWork.Entry(company).State = EntityState.Modified;
            _unitOfWork.Companies.Update(company);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CompanyExists(id))
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

        // POST: api/Companys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            await _unitOfWork.Companies.Insert(company);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCompany", new { id = company.Id }, company);
        }

        // DELETE: api/Companys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await _unitOfWork.Companies.Get(q => q.Id== id);
            if (company == null)
            {
                return NotFound();
            }


            await _unitOfWork.Companies.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CompanyExists(int id)
        {
            var make = await _unitOfWork.Companies.Get(q => q.Id == id);
            return make != null;
        }
    }
}
