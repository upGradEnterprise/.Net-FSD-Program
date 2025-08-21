using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsApiController : ControllerBase
    {

        private readonly AppDbContext _context;

        public EmpsApiController(AppDbContext context)
        {
                _context = context;
        }


        // GET :  api/EmpsApi

        [HttpGet]
        public async  Task< ActionResult< IEnumerable<Emp> > > GetAll()
        {
            var emps = await _context.Emps.ToListAsync();
            return Ok(emps);
        }


        // GET :  api/EmpsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emp>> GetById(int id)
        {
            var emp = await _context.Emps.FindAsync(id);

            if (emp != null)
            {
                return Ok(emp);
            }
            else
            {
                return BadRequest("Requested Employee Id does not exists.");
            }
        }


        // POST :  api/EmpsApi
        [HttpPost]
        public async Task<ActionResult> Create(Emp emp)
        {
            await  _context.Emps.AddAsync(emp);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = emp.Id }, emp);
        //    return Ok(new { Status = "Requested employee details are updated." });

        }

        // PUT :  api/EmpsApi/id
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Emp emp)
        {
            if (id != emp.Id)
                return BadRequest("Invalid Employee Id");

            _context.Emps.Update(emp);
            await _context.SaveChangesAsync();
        //    return NoContent();
            return Ok(new { Status = "Requested employee details are updated."  });
        }


        // DELETE :  api/EmpsApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            var emp = await _context.Emps.FindAsync(id);

            if (emp != null)
            {
                _context.Emps.Remove(emp);
                await _context.SaveChangesAsync();
                //    return NoContent();
                return Ok(new { Status = "Requested employee details are deleted." });
            }
            else
            {
                return BadRequest("Requested Employee Id does not exists.");
            }
        }
    }
}
