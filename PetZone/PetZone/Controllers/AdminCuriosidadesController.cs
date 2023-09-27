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
    public class AdminCuriosidadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminCuriosidadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminCuriosidades
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Curiosidades.Include(c => c.Raca);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AdminCuriosidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Curiosidades == null)
            {
                return NotFound();
            }

            var curiosidade = await _context.Curiosidades
                .Include(c => c.Raca)
                .FirstOrDefaultAsync(m => m.CuriosidadeId == id);
            if (curiosidade == null)
            {
                return NotFound();
            }

            return View(curiosidade);
        }

        // GET: AdminCuriosidades/Create
        public IActionResult Create()
        {
            ViewData["RacaId"] = new SelectList(_context.Racas, "RacaId", "Nome");
            return View();
        }

        // POST: AdminCuriosidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CuriosidadeId,Nome,Descricao,Imagem,RacaId")] Curiosidade curiosidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(curiosidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RacaId"] = new SelectList(_context.Racas, "RacaId", "Nome", curiosidade.RacaId);
            return View(curiosidade);
        }

        // GET: AdminCuriosidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Curiosidades == null)
            {
                return NotFound();
            }

            var curiosidade = await _context.Curiosidades.FindAsync(id);
            if (curiosidade == null)
            {
                return NotFound();
            }
            ViewData["RacaId"] = new SelectList(_context.Racas, "RacaId", "Nome", curiosidade.RacaId);
            return View(curiosidade);
        }

        // POST: AdminCuriosidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CuriosidadeId,Nome,Descricao,Imagem,RacaId")] Curiosidade curiosidade)
        {
            if (id != curiosidade.CuriosidadeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curiosidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuriosidadeExists(curiosidade.CuriosidadeId))
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
            ViewData["RacaId"] = new SelectList(_context.Racas, "RacaId", "Nome", curiosidade.RacaId);
            return View(curiosidade);
        }

        // GET: AdminCuriosidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Curiosidades == null)
            {
                return NotFound();
            }

            var curiosidade = await _context.Curiosidades
                .Include(c => c.Raca)
                .FirstOrDefaultAsync(m => m.CuriosidadeId == id);
            if (curiosidade == null)
            {
                return NotFound();
            }

            return View(curiosidade);
        }

        // POST: AdminCuriosidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Curiosidades == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Curiosidades'  is null.");
            }
            var curiosidade = await _context.Curiosidades.FindAsync(id);
            if (curiosidade != null)
            {
                _context.Curiosidades.Remove(curiosidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuriosidadeExists(int id)
        {
          return _context.Curiosidades.Any(e => e.CuriosidadeId == id);
        }
    }
}
