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
    public class DdtDetailsController : ControllerBase
    {
        private readonly AleGestContext _context;

        public DdtDetailsController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/DdtDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DdtDetail>>> GetDdtDetails()
        {
          if (_context.DdtDetails == null)
          {
              return NotFound();
          }
            return await _context.DdtDetails.ToListAsync();
        }

        // GET: api/DdtDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DdtDetail>> GetDdtDetail(int id)
        {
          if (_context.DdtDetails == null)
          {
              return NotFound();
          }
            var ddtDetail = await _context.DdtDetails.FindAsync(id);

            if (ddtDetail == null)
            {
                return NotFound();
            }

            return ddtDetail;
        }

        // PUT: api/DdtDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDdtDetail(int id, DdtDetail ddtDetail)
        {
            if (id != ddtDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(ddtDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DdtDetailExists(id))
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

        // POST: api/DdtDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DdtDetail>> PostDdtDetail(DdtDetail ddtDetail)
        {
          if (_context.DdtDetails == null)
          {
              return Problem("Entity set 'AleGestContext.DdtDetails'  is null.");
          }
            _context.DdtDetails.Add(ddtDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDdtDetail", new { id = ddtDetail.Id }, ddtDetail);
        }

        // DELETE: api/DdtDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDdtDetail(int id)
        {
            if (_context.DdtDetails == null)
            {
                return NotFound();
            }
            var ddtDetail = await _context.DdtDetails.FindAsync(id);
            if (ddtDetail == null)
            {
                return NotFound();
            }

            _context.DdtDetails.Remove(ddtDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DdtDetailExists(int id)
        {
            return (_context.DdtDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
