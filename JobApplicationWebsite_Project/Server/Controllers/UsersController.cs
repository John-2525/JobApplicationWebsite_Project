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

 
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Users
        [HttpGet]
        

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _unitOfWork.Users.Get(q => q.Id == id);
            

            
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            //_unitOfWork.Entry(user).State = EntityState.Modified;
            _unitOfWork.Users.Update(user);
            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await UserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            await _unitOfWork.Users.Insert(user);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _unitOfWork.Users.Get(q => q.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            
            await _unitOfWork.Users.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private  async Task<bool> UserExists(int id)
        {
            var make = await _unitOfWork.Users.Get(q => q.Id == id);
            return make != null;
        }
    }
}
