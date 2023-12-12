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
    public class ProductPhotoesController : ControllerBase
    {
        private readonly AleGestContext _context;

        public ProductPhotoesController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/ProductPhotoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductPhoto>>> GetProductPhotos()
        {
          if (_context.ProductPhotos == null)
          {
              return NotFound();
          }
            return await _context.ProductPhotos.ToListAsync();
        }

        // GET: api/ProductPhotoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductPhoto>> GetProductPhoto(int id)
        {
          if (_context.ProductPhotos == null)
          {
              return NotFound();
          }
            var productPhoto = await _context.ProductPhotos.FindAsync(id);

            if (productPhoto == null)
            {
                return NotFound();
            }

            return productPhoto;
        }

        // PUT: api/ProductPhotoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductPhoto(int id, ProductPhoto productPhoto)
        {
            if (id != productPhoto.Id)
            {
                return BadRequest();
            }

            _context.Entry(productPhoto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductPhotoExists(id))
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

        // POST: api/ProductPhotoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductPhoto>> PostProductPhoto(ProductPhoto productPhoto)
        {
          if (_context.ProductPhotos == null)
          {
              return Problem("Entity set 'AleGestContext.ProductPhotos'  is null.");
          }
            _context.ProductPhotos.Add(productPhoto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductPhoto", new { id = productPhoto.Id }, productPhoto);
        }

        // DELETE: api/ProductPhotoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductPhoto(int id)
        {
            if (_context.ProductPhotos == null)
            {
                return NotFound();
            }
            var productPhoto = await _context.ProductPhotos.FindAsync(id);
            if (productPhoto == null)
            {
                return NotFound();
            }

            _context.ProductPhotos.Remove(productPhoto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductPhotoExists(int id)
        {
            return (_context.ProductPhotos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
