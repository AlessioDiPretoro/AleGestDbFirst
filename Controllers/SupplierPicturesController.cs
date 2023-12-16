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
    public class SupplierPicturesController : ControllerBase
    {
        private readonly AleGestContext _context;

        public SupplierPicturesController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/SupplierPicturees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierPicture>>> GetSupplierPictures()
        {
          if (_context.SupplierPictures == null)
          {
              return NotFound();
          }
            return await _context.SupplierPictures.ToListAsync();
        }

        // GET: api/SupplierPicturees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierPicture>> GetSupplierPicture(int id)
        {
          if (_context.SupplierPictures == null)
          {
              return NotFound();
          }
            var supplierPicture = await _context.SupplierPictures.FindAsync(id);

            if (supplierPicture == null)
            {
                return NotFound();
            }

            return supplierPicture;
        }

        // PUT: api/SupplierPicturees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierPicture(int id, SupplierPicture supplierPicture)
        {
            if (id != supplierPicture.Id)
            {
                return BadRequest();
            }

            _context.Entry(supplierPicture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierPictureExists(id))
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

        // POST: api/SupplierPicturees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupplierPicture>> PostSupplierPicture(SupplierPicture supplierPicture)
        {
          if (_context.SupplierPictures == null)
          {
              return Problem("Entity set 'AleGestContext.SupplierPictures'  is null.");
          }
            _context.SupplierPictures.Add(supplierPicture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplierPicture", new { id = supplierPicture.Id }, supplierPicture);
        }

        // DELETE: api/SupplierPicturees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierPicture(int id)
        {
            if (_context.SupplierPictures == null)
            {
                return NotFound();
            }
            var supplierPicture = await _context.SupplierPictures.FindAsync(id);
            if (supplierPicture == null)
            {
                return NotFound();
            }

            _context.SupplierPictures.Remove(supplierPicture);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierPictureExists(int id)
        {
            return (_context.SupplierPictures?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
