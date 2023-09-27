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
    public class AdminFichasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminFichasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminFichas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Fichas.Include(f => f.Pet).Include(f => f.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AdminFichas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Fichas == null)
            {
                return NotFound();
            }

            var ficha = await _context.Fichas
                .Include(f => f.Pet)
                .Include(f => f.Usuario)
                .FirstOrDefaultAsync(m => m.FichaId == id);
            if (ficha == null)
            {
                return NotFound();
            }

            return View(ficha);
        }

        // GET: AdminFichas/Create
        public IActionResult Create()
        {
            ViewData["PetId"] = new SelectList(_context.Pets, "PetId", "Descricao");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id");
            return View();
        }

        // POST: AdminFichas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FichaId,Cpf,Renda,Motivo,PedidoEnviado,UsuarioId,PetId")] Ficha ficha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ficha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PetId"] = new SelectList(_context.Pets, "PetId", "Descricao", ficha.PetId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Id", ficha.UsuarioId);
            return View(ficha);
        }

        // GET: AdminFichas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Fichas == null)
            {
                return NotFound();
            }

            var ficha = await _context.Fichas.FindAsync(id);
            if (ficha == null)
            {
                return NotFound();
            }
            ViewData["PetId"] = new SelectList(_context.Pets, "PetId", "Descricao", ficha.PetId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", ficha.UsuarioId);
            return View(ficha);
        }

        // POST: AdminFichas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FichaId,Cpf,Renda,Motivo,PedidoEnviado,UsuarioId,PetId")] Ficha ficha)
        {
            if (id != ficha.FichaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ficha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FichaExists(ficha.FichaId))
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
            ViewData["PetId"] = new SelectList(_context.Pets, "PetId", "Descricao", ficha.PetId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", ficha.UsuarioId);
            return View(ficha);
        }

        // GET: AdminFichas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Fichas == null)
            {
                return NotFound();
            }

            var ficha = await _context.Fichas
                .Include(f => f.Pet)
                .Include(f => f.Usuario)
                .FirstOrDefaultAsync(m => m.FichaId == id);
            if (ficha == null)
            {
                return NotFound();
            }

            return View(ficha);
        }

        // POST: AdminFichas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Fichas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Fichas'  is null.");
            }
            var ficha = await _context.Fichas.FindAsync(id);
            if (ficha != null)
            {
                _context.Fichas.Remove(ficha);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FichaExists(int id)
        {
          return _context.Fichas.Any(e => e.FichaId == id);
        }
    }
}
