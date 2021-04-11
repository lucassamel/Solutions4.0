using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solutions4.Context;
using Solutions4.Model;

namespace Solutions4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatentesController : ControllerBase
    {
        private readonly SolutionsContext _context;

        public PatentesController(SolutionsContext context)
        {
            _context = context;
        }

        // GET: api/Patentes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patente>>> GetPatentes()
        {
            return await _context.Patentes.ToListAsync();
        }

        // GET: api/Patentes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patente>> GetPatente(int id)
        {
            var patente = await _context.Patentes.FindAsync(id);

            if (patente == null)
            {
                return NotFound();
            }

            return patente;
        }

        // PUT: api/Patentes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatente(int id, Patente patente)
        {
            if (id != patente.Id)
            {
                return BadRequest();
            }

            _context.Entry(patente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatenteExists(id))
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

        // POST: api/Patentes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Patente>> PostPatente(Patente patente)
        {
            _context.Patentes.Add(patente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatente", new { id = patente.Id }, patente);
        }

        // DELETE: api/Patentes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Patente>> DeletePatente(int id)
        {
            var patente = await _context.Patentes.FindAsync(id);
            if (patente == null)
            {
                return NotFound();
            }

            _context.Patentes.Remove(patente);
            await _context.SaveChangesAsync();

            return patente;
        }

        private bool PatenteExists(int id)
        {
            return _context.Patentes.Any(e => e.Id == id);
        }
    }
}
