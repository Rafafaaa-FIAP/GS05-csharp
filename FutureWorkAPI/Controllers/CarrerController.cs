using Microsoft.AspNetCore.Mvc;
using FutureWorkAPI.Data;
using FutureWorkAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FutureWorkAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CareersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CareersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/careers
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Careers.ToListAsync());
        }

        // GET: api/careers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var career = await _context.Careers.FindAsync(id);
            if (career == null) return NotFound();

            return Ok(career);
        }

        // POST: api/careers
        [HttpPost]
        public async Task<IActionResult> Create(Career career)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Careers.Add(career);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = career.Id }, career);
        }

        // PUT: api/careers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Career updated)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != updated.Id)
                return BadRequest();

            var existing = await _context.Careers.FindAsync(id);
            if (existing == null) return NotFound();

            existing.Title = updated.Title;
            existing.Description = updated.Description;
            existing.SkillLevel = updated.SkillLevel;
            existing.Category = updated.Category;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/careers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var career = await _context.Careers.FindAsync(id);
            if (career == null) return NotFound();

            _context.Careers.Remove(career);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
