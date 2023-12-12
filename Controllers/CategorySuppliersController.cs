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
    public class CategorySuppliersController : ControllerBase
    {
        private readonly AleGestContext _context;

        public CategorySuppliersController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/CategorySuppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategorySupplier>>> GetCategorySuppliers()
        {
          if (_context.CategorySuppliers == null)
          {
              return NotFound();
          }
            return await _context.CategorySuppliers.ToListAsync();
        }

        // GET: api/CategorySuppliers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategorySupplier>> GetCategorySupplier(int id)
        {
          if (_context.CategorySuppliers == null)
          {
              return NotFound();
          }
            var categorySupplier = await _context.CategorySuppliers.FindAsync(id);

            if (categorySupplier == null)
            {
                return NotFound();
            }

            return categorySupplier;
        }

        // PUT: api/CategorySuppliers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorySupplier(int id, CategorySupplier categorySupplier)
        {
            if (id != categorySupplier.Id)
            {
                return BadRequest();
            }

            _context.Entry(categorySupplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorySupplierExists(id))
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

        // POST: api/CategorySuppliers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CategorySupplier>> PostCategorySupplier(CategorySupplier categorySupplier)
        {
          if (_context.CategorySuppliers == null)
          {
              return Problem("Entity set 'AleGestContext.CategorySuppliers'  is null.");
          }
            _context.CategorySuppliers.Add(categorySupplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategorySupplier", new { id = categorySupplier.Id }, categorySupplier);
        }

        // DELETE: api/CategorySuppliers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorySupplier(int id)
        {
            if (_context.CategorySuppliers == null)
            {
                return NotFound();
            }
            var categorySupplier = await _context.CategorySuppliers.FindAsync(id);
            if (categorySupplier == null)
            {
                return NotFound();
            }

            _context.CategorySuppliers.Remove(categorySupplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategorySupplierExists(int id)
        {
            return (_context.CategorySuppliers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
