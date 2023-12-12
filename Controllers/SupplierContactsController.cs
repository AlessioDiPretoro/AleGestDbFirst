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
    public class SupplierContactsController : ControllerBase
    {
        private readonly AleGestContext _context;

        public SupplierContactsController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/SupplierContacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierContact>>> GetSupplierContacts()
        {
          if (_context.SupplierContacts == null)
          {
              return NotFound();
          }
            return await _context.SupplierContacts.ToListAsync();
        }

        // GET: api/SupplierContacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierContact>> GetSupplierContact(int id)
        {
          if (_context.SupplierContacts == null)
          {
              return NotFound();
          }
            var supplierContact = await _context.SupplierContacts.FindAsync(id);

            if (supplierContact == null)
            {
                return NotFound();
            }

            return supplierContact;
        }

        // PUT: api/SupplierContacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierContact(int id, SupplierContact supplierContact)
        {
            if (id != supplierContact.Id)
            {
                return BadRequest();
            }

            _context.Entry(supplierContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierContactExists(id))
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

        // POST: api/SupplierContacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupplierContact>> PostSupplierContact(SupplierContact supplierContact)
        {
          if (_context.SupplierContacts == null)
          {
              return Problem("Entity set 'AleGestContext.SupplierContacts'  is null.");
          }
            _context.SupplierContacts.Add(supplierContact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplierContact", new { id = supplierContact.Id }, supplierContact);
        }

        // DELETE: api/SupplierContacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierContact(int id)
        {
            if (_context.SupplierContacts == null)
            {
                return NotFound();
            }
            var supplierContact = await _context.SupplierContacts.FindAsync(id);
            if (supplierContact == null)
            {
                return NotFound();
            }

            _context.SupplierContacts.Remove(supplierContact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierContactExists(int id)
        {
            return (_context.SupplierContacts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
