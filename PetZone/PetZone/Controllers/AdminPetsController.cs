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
    public class AdminPetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminPetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdminPets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pets.Include(p => p.Genero).Include(p => p.Raca).Include(p => p.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AdminPets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pets == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets
                .Include(p => p.Genero)
                .Include(p => p.Raca)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.PetId == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // GET: AdminPets/Create
        public IActionResult Create()
        {
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nome");
            ViewData["RacaId"] = new SelectList(_context.Racas, "RacaId", "Nome");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome");
            return View();
        }

        // POST: AdminPets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PetId,Nome,Descricao,Idade,Peso,ImgLink,ImgLinkII,GeneroId,RacaId,UsuarioId,ParaAdocao")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nome", pet.GeneroId);
            ViewData["RacaId"] = new SelectList(_context.Racas, "RacaId", "Nome", pet.RacaId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", pet.UsuarioId);
            return View(pet);
        }

        // GET: AdminPets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pets == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nome", pet.GeneroId);
            ViewData["RacaId"] = new SelectList(_context.Racas, "RacaId", "Nome", pet.RacaId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", pet.UsuarioId);
            return View(pet);
        }

        // POST: AdminPets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PetId,Nome,Descricao,Idade,Peso,ImgLink,ImgLinkII,GeneroId,RacaId,UsuarioId,ParaAdocao")] Pet pet)
        {
            if (id != pet.PetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.PetId))
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
            ViewData["GeneroId"] = new SelectList(_context.Generos, "GeneroId", "Nome", pet.GeneroId);
            ViewData["RacaId"] = new SelectList(_context.Racas, "RacaId", "Nome", pet.RacaId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", pet.UsuarioId);
            return View(pet);
        }

        // GET: AdminPets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pets == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets
                .Include(p => p.Genero)
                .Include(p => p.Raca)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.PetId == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // POST: AdminPets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pets == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Pets'  is null.");
            }
            var pet = await _context.Pets.FindAsync(id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetExists(int id)
        {
          return _context.Pets.Any(e => e.PetId == id);
        }
    }
}
