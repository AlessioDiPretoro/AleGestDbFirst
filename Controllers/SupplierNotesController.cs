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
    public class SupplierNotesController : ControllerBase
    {
        private readonly AleGestContext _context;

        public SupplierNotesController(AleGestContext context)
        {
            _context = context;
        }

        // GET: api/SupplierNotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierNote>>> GetSupplierNotes()
        {
          if (_context.SupplierNotes == null)
          {
              return NotFound();
          }
            return await _context.SupplierNotes.ToListAsync();
        }

        // GET: api/SupplierNotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierNote>> GetSupplierNote(int id)
        {
          if (_context.SupplierNotes == null)
          {
              return NotFound();
          }
            var supplierNote = await _context.SupplierNotes.FindAsync(id);

            if (supplierNote == null)
            {
                return NotFound();
            }

            return supplierNote;
        }

        // PUT: api/SupplierNotes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierNote(int id, SupplierNote supplierNote)
        {
            if (id != supplierNote.Id)
            {
                return BadRequest();
            }

            _context.Entry(supplierNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierNoteExists(id))
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

        // POST: api/SupplierNotes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupplierNote>> PostSupplierNote(SupplierNote supplierNote)
        {
          if (_context.SupplierNotes == null)
          {
              return Problem("Entity set 'AleGestContext.SupplierNotes'  is null.");
          }
            _context.SupplierNotes.Add(supplierNote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplierNote", new { id = supplierNote.Id }, supplierNote);
        }

        // DELETE: api/SupplierNotes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierNote(int id)
        {
            if (_context.SupplierNotes == null)
            {
                return NotFound();
            }
            var supplierNote = await _context.SupplierNotes.FindAsync(id);
            if (supplierNote == null)
            {
                return NotFound();
            }

            _context.SupplierNotes.Remove(supplierNote);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierNoteExists(int id)
        {
            return (_context.SupplierNotes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
