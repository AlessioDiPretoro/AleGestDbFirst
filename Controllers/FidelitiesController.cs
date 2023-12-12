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
    public class FidelitiesController : ControllerBase
    {
        private readonly AleGestContext _context;

        public FidelitiesController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/Fidelities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fidelity>>> GetFidelities()
        {
          if (_context.Fidelities == null)
          {
              return NotFound();
          }
            return await _context.Fidelities.ToListAsync();
        }

        // GET: api/Fidelities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fidelity>> GetFidelity(int id)
        {
          if (_context.Fidelities == null)
          {
              return NotFound();
          }
            var fidelity = await _context.Fidelities.FindAsync(id);

            if (fidelity == null)
            {
                return NotFound();
            }

            return fidelity;
        }

        // PUT: api/Fidelities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFidelity(int id, Fidelity fidelity)
        {
            if (id != fidelity.Id)
            {
                return BadRequest();
            }

            _context.Entry(fidelity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FidelityExists(id))
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

        // POST: api/Fidelities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fidelity>> PostFidelity(Fidelity fidelity)
        {
          if (_context.Fidelities == null)
          {
              return Problem("Entity set 'AleGestContext.Fidelities'  is null.");
          }
            _context.Fidelities.Add(fidelity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFidelity", new { id = fidelity.Id }, fidelity);
        }

        // DELETE: api/Fidelities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFidelity(int id)
        {
            if (_context.Fidelities == null)
            {
                return NotFound();
            }
            var fidelity = await _context.Fidelities.FindAsync(id);
            if (fidelity == null)
            {
                return NotFound();
            }

            _context.Fidelities.Remove(fidelity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FidelityExists(int id)
        {
            return (_context.Fidelities?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
