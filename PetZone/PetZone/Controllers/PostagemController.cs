using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetZone.Data;
using PetZone.Models;
using System.Security.Claims;

namespace PetZone.Controllers
{
    public class PostagemController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PostagemController(ApplicationDbContext db, IWebHostEnvironment hostEnvironment)
        {
            _db = db;
            _hostEnvironment = hostEnvironment;
        }



        [HttpGet]
        public IActionResult AdicionarPet()
        {
            ViewData["ListGenre"] = new SelectList(_db.Generos, "GeneroId", "Nome");
            ViewData["ListBreed"] = new SelectList(_db.Racas, "RacaId", "Nome");
            Pet pet = new Pet();
            pet.UsuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            return View(pet);
        }


        [HttpPost]
        public async Task<ActionResult> AdicionarPet(Pet pet, IFormFile file, IFormFile files)
        {
            if (ModelState.IsValid)
            {
                if (files != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + files.FileName;
                    string uploads = Path.Combine(wwwRootPath, @"images\PETS");
                    string newFile = Path.Combine(uploads, fileName);
                    using (var stream = new FileStream(newFile, FileMode.Create))
                    {
                        files.CopyTo(stream);
                    }
                    pet.ImgLink = @"\images\PETS\" + fileName;
                }


                if (file != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + file.FileName;
                    string uploads = Path.Combine(wwwRootPath, @"images\PETS");
                    string newFile = Path.Combine(uploads, fileName);
                    using (var stream = new FileStream(newFile, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    pet.ImgLinkII = @"\images\PETS\" + fileName;
                }

                _db.Pets.Add(pet);
                await _db.SaveChangesAsync();
                return View("~/Views/Postagem/PostCompleto.cshtml", pet);
            }
            ViewData["ListGenre"] = new SelectList(_db.Generos, "GeneroId", "Nome");
            ViewData["ListBreed"] = new SelectList(_db.Racas, "RacaId", "Nome");
            return View(pet);
        }


    }
}
