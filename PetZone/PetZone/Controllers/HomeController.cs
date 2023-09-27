using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetZone.Data;
using PetZone.Models;
using System.Diagnostics;

namespace PetZone.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            /*var pets = await _db.Pets.Include(r=> r.Raca).Include(g=>g.Genero).Include(e=>e.Raca.Especie).Include(u=> u.Usuario).ToListAsync();*/
            var applicationDbContext = _db.Pets.Include(p => p.Genero).Include(p => p.Raca).Include(p => p.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult SobreNos()
        {
            return View();
        }

        public IActionResult Termos()
        {
            return View();
        }

        public IActionResult Detalhes(int petId)
        {
            var pet = _db.Pets.Include(p => p.Genero).Include(p => p.Raca).Include(p => p.Usuario).Include(t => t.Raca.Especie).FirstOrDefault(p => p.PetId == petId);
            return View(pet);
        }

        public async Task<IActionResult> Curiosidades()
        {
            var curiosidades = await _db.Curiosidades.Include(e=> e.Raca.Especie).Include(r=> r.Raca).ToListAsync();
            return View(curiosidades);
        }

        public IActionResult Info(string userId)
        {
            var user = _db.Usuarios.FirstOrDefault(p => p.Id == userId);
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}