using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AleGestDbFirst.Models;

namespace AleGestDbFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DdtsController : ControllerBase
    {
        private readonly AleGestContext _context;

        public DdtsController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/Ddts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ddt>>> GetDdts()
        {
          if (_context.Ddts == null)
          {
              return NotFound();
          }
            return await _context.Ddts.ToListAsync();
        }

        // GET: api/Ddts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ddt>> GetDdt(int id)
        {
          if (_context.Ddts == null)
          {
              return NotFound();
          }
            var ddt = await _context.Ddts.FindAsync(id);

            if (ddt == null)
            {
                return NotFound();
            }

            return ddt;
        }

        // PUT: api/Ddts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDdt(int id, Ddt ddt)
        {
            if (id != ddt.Id)
            {
                return BadRequest();
            }

            _context.Entry(ddt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DdtExists(id))
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

        // POST: api/Ddts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ddt>> PostDdt(Ddt ddt)
        {
          if (_context.Ddts == null)
          {
              return Problem("Entity set 'AleGestContext.Ddts'  is null.");
          }
            _context.Ddts.Add(ddt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDdt", new { id = ddt.Id }, ddt);
        }

        // DELETE: api/Ddts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDdt(int id)
        {
            if (_context.Ddts == null)
            {
                return NotFound();
            }
            var ddt = await _context.Ddts.FindAsync(id);
            if (ddt == null)
            {
                return NotFound();
            }

            _context.Ddts.Remove(ddt);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DdtExists(int id)
        {
            return (_context.Ddts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
