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
    public class ProductSuppliersController : ControllerBase
    {
        private readonly AleGestContext _context;

        public ProductSuppliersController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/ProductSuppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductSupplier>>> GetProductSuppliers()
        {
          if (_context.ProductSuppliers == null)
          {
              return NotFound();
          }
            return await _context.ProductSuppliers.ToListAsync();
        }

        // GET: api/ProductSuppliers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductSupplier>> GetProductSupplier(int id)
        {
          if (_context.ProductSuppliers == null)
          {
              return NotFound();
          }
            var productSupplier = await _context.ProductSuppliers.FindAsync(id);

            if (productSupplier == null)
            {
                return NotFound();
            }

            return productSupplier;
        }

        // PUT: api/ProductSuppliers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductSupplier(int id, ProductSupplier productSupplier)
        {
            if (id != productSupplier.Id)
            {
                return BadRequest();
            }

            _context.Entry(productSupplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductSupplierExists(id))
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

        // POST: api/ProductSuppliers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductSupplier>> PostProductSupplier(ProductSupplier productSupplier)
        {
          if (_context.ProductSuppliers == null)
          {
              return Problem("Entity set 'AleGestContext.ProductSuppliers'  is null.");
          }
            _context.ProductSuppliers.Add(productSupplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductSupplier", new { id = productSupplier.Id }, productSupplier);
        }

        // DELETE: api/ProductSuppliers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductSupplier(int id)
        {
            if (_context.ProductSuppliers == null)
            {
                return NotFound();
            }
            var productSupplier = await _context.ProductSuppliers.FindAsync(id);
            if (productSupplier == null)
            {
                return NotFound();
            }

            _context.ProductSuppliers.Remove(productSupplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductSupplierExists(int id)
        {
            return (_context.ProductSuppliers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
