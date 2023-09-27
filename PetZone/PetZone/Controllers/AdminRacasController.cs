using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetZone.Data;
using PetZone.Models;

namespace PetZone.Controllers
{
    public class AdminRacasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminRacasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminRacas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Racas.Include(r => r.Especie);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AdminRacas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Racas == null)
            {
                return NotFound();
            }

            var raca = await _context.Racas
                .Include(r => r.Especie)
                .FirstOrDefaultAsync(m => m.RacaId == id);
            if (raca == null)
            {
                return NotFound();
            }

            return View(raca);
        }

        // GET: AdminRacas/Create
        public IActionResult Create()
        {
            ViewData["EspecieId"] = new SelectList(_context.Especies, "EspecieId", "Nome");
            return View();
        }

        // POST: AdminRacas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RacaId,Nome,EspecieId")] Raca raca)
        {
            if (ModelState.IsValid)
            {
                _context.Add(raca);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EspecieId"] = new SelectList(_context.Especies, "EspecieId", "Nome", raca.EspecieId);
            return View(raca);
        }

        // GET: AdminRacas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Racas == null)
            {
                return NotFound();
            }

            var raca = await _context.Racas.FindAsync(id);
            if (raca == null)
            {
                return NotFound();
            }
            ViewData["EspecieId"] = new SelectList(_context.Especies, "EspecieId", "Nome", raca.EspecieId);
            return View(raca);
        }

        // POST: AdminRacas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RacaId,Nome,EspecieId")] Raca raca)
        {
            if (id != raca.RacaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(raca);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RacaExists(raca.RacaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EspecieId"] = new SelectList(_context.Especies, "EspecieId", "Nome", raca.EspecieId);
            return View(raca);
        }

        // GET: AdminRacas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Racas == null)
            {
                return NotFound();
            }

            var raca = await _context.Racas
                .Include(r => r.Especie)
                .FirstOrDefaultAsync(m => m.RacaId == id);
            if (raca == null)
            {
                return NotFound();
            }

            return View(raca);
        }

        // POST: AdminRacas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Racas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Racas'  is null.");
            }
            var raca = await _context.Racas.FindAsync(id);
            if (raca != null)
            {
                _context.Racas.Remove(raca);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RacaExists(int id)
        {
          return _context.Racas.Any(e => e.RacaId == id);
        }
    }
}
