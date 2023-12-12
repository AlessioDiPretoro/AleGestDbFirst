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
    public class SupplierContactRelsController : ControllerBase
    {
        private readonly AleGestContext _context;

        public SupplierContactRelsController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/SupplierContactRels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierContactRel>>> GetSupplierContactRels()
        {
          if (_context.SupplierContactRels == null)
          {
              return NotFound();
          }
            return await _context.SupplierContactRels.ToListAsync();
        }

        // GET: api/SupplierContactRels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierContactRel>> GetSupplierContactRel(int id)
        {
          if (_context.SupplierContactRels == null)
          {
              return NotFound();
          }
            var supplierContactRel = await _context.SupplierContactRels.FindAsync(id);

            if (supplierContactRel == null)
            {
                return NotFound();
            }

            return supplierContactRel;
        }

        // PUT: api/SupplierContactRels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierContactRel(int id, SupplierContactRel supplierContactRel)
        {
            if (id != supplierContactRel.Id)
            {
                return BadRequest();
            }

            _context.Entry(supplierContactRel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierContactRelExists(id))
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

        // POST: api/SupplierContactRels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupplierContactRel>> PostSupplierContactRel(SupplierContactRel supplierContactRel)
        {
          if (_context.SupplierContactRels == null)
          {
              return Problem("Entity set 'AleGestContext.SupplierContactRels'  is null.");
          }
            _context.SupplierContactRels.Add(supplierContactRel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplierContactRel", new { id = supplierContactRel.Id }, supplierContactRel);
        }

        // DELETE: api/SupplierContactRels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierContactRel(int id)
        {
            if (_context.SupplierContactRels == null)
            {
                return NotFound();
            }
            var supplierContactRel = await _context.SupplierContactRels.FindAsync(id);
            if (supplierContactRel == null)
            {
                return NotFound();
            }

            _context.SupplierContactRels.Remove(supplierContactRel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierContactRelExists(int id)
        {
            return (_context.SupplierContactRels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
