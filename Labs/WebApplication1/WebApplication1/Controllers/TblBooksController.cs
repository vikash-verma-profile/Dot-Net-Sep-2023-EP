using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblBooksController : ControllerBase
    {
        private readonly BookdbContext _context;

        public TblBooksController(BookdbContext context)
        {
            _context = context;
        }

        // GET: api/TblBooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblBook>>> GetTblBooks()
        {
          if (_context.TblBooks == null)
          {
              return NotFound();
          }
            return await _context.TblBooks.ToListAsync();
        }

        // GET: api/TblBooks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblBook>> GetTblBook(int id)
        {
          if (_context.TblBooks == null)
          {
              return NotFound();
          }
            var tblBook = await _context.TblBooks.FindAsync(id);

            if (tblBook == null)
            {
                return NotFound();
            }

            return tblBook;
        }

        // PUT: api/TblBooks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblBook(int id, TblBook tblBook)
        {
            if (id != tblBook.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblBookExists(id))
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

        // POST: api/TblBooks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblBook>> PostTblBook(TblBook tblBook)
        {
          if (_context.TblBooks == null)
          {
              return Problem("Entity set 'BookdbContext.TblBooks'  is null.");
          }
            _context.TblBooks.Add(tblBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblBook", new { id = tblBook.Id }, tblBook);
        }

        // DELETE: api/TblBooks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblBook(int id)
        {
            if (_context.TblBooks == null)
            {
                return NotFound();
            }
            var tblBook = await _context.TblBooks.FindAsync(id);
            if (tblBook == null)
            {
                return NotFound();
            }

            _context.TblBooks.Remove(tblBook);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblBookExists(int id)
        {
            return (_context.TblBooks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
