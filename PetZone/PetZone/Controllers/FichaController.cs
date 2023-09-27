using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetZone.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using PetZone.Data;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PetZone.Controllers
{
    public class FichaController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<Usuario> _userManager;

        public FichaController(ApplicationDbContext db, IWebHostEnvironment hostEnvironment, UserManager<Usuario> userManager)
        {
            _db = db;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
        }


        [HttpGet]
        public async Task<IActionResult> Checkout(int petId)
        {
            Ficha ficha = new Ficha();
            ficha.UsuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usuario = _db.Usuarios.FirstOrDefault(u => u.Id == ficha.UsuarioId);
            ficha.Pet = _db.Pets.Find(petId);
            ficha.Usuario = usuario;
            return View(ficha);
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Ficha ficha, int petId)
        {
            if (ModelState.IsValid)
            {
                _db.Fichas.Add(ficha);
                ficha.PedidoEnviado = DateTime.Now;
                await _db.SaveChangesAsync();
                ViewBag.CheckoutCompletoMensagem = "Obrigado por ter iniciado o processo de adoção, sua ficha foi encaminhada e será verificada em breve!!";
                ficha.Pet = _db.Pets.Find(ficha.PetId);
                ficha.Usuario = _db.Usuarios.FirstOrDefault(u => u.Id == ficha.UsuarioId);
                return View("~/Views/Ficha/CheckoutCompleto.cshtml", ficha);
            }
            return View(ficha);
        }

          public IActionResult CheckoutCompleto()
        {
            var fch = _db.Fichas.Include(p => p.Usuario).Include(a=> a.Pet).Include(s=>s.Pet.Raca).Include(v=>v.Pet.Raca.Especie);
            return View(fch);
        }


        /*public IActionResult Checkout(int petId)
        {
            var pet = _petRepository.Pets.FirstOrDefault(p => p.PetId == petId);
            return View(pet);
        }*/


    }
}