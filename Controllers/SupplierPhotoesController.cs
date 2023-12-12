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
    public class SupplierPhotoesController : ControllerBase
    {
        private readonly AleGestContext _context;

        public SupplierPhotoesController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/SupplierPhotoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierPhoto>>> GetSupplierPhotos()
        {
          if (_context.SupplierPhotos == null)
          {
              return NotFound();
          }
            return await _context.SupplierPhotos.ToListAsync();
        }

        // GET: api/SupplierPhotoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierPhoto>> GetSupplierPhoto(int id)
        {
          if (_context.SupplierPhotos == null)
          {
              return NotFound();
          }
            var supplierPhoto = await _context.SupplierPhotos.FindAsync(id);

            if (supplierPhoto == null)
            {
                return NotFound();
            }

            return supplierPhoto;
        }

        // PUT: api/SupplierPhotoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierPhoto(int id, SupplierPhoto supplierPhoto)
        {
            if (id != supplierPhoto.Id)
            {
                return BadRequest();
            }

            _context.Entry(supplierPhoto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierPhotoExists(id))
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

        // POST: api/SupplierPhotoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupplierPhoto>> PostSupplierPhoto(SupplierPhoto supplierPhoto)
        {
          if (_context.SupplierPhotos == null)
          {
              return Problem("Entity set 'AleGestContext.SupplierPhotos'  is null.");
          }
            _context.SupplierPhotos.Add(supplierPhoto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplierPhoto", new { id = supplierPhoto.Id }, supplierPhoto);
        }

        // DELETE: api/SupplierPhotoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierPhoto(int id)
        {
            if (_context.SupplierPhotos == null)
            {
                return NotFound();
            }
            var supplierPhoto = await _context.SupplierPhotos.FindAsync(id);
            if (supplierPhoto == null)
            {
                return NotFound();
            }

            _context.SupplierPhotos.Remove(supplierPhoto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierPhotoExists(int id)
        {
            return (_context.SupplierPhotos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
