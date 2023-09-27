using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetZone.Data;
using PetZone.Models;
using PetZone.ViewModels;

namespace PetZone.Controllers
{
    public class PetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetController(ApplicationDbContext context)
        {
            
            _context = context;

        }

        public IActionResult List(string especie)
        {

            IEnumerable<Pet> pets;
            string especieAtual = string.Empty;

            if (string.IsNullOrEmpty(especie))
            {
                pets = _context.Pets.OrderBy(l => l.PetId);
                especieAtual = "Todos os Pets";
            }

            else
            {
                pets = _context.Pets.Include(u => u.Usuario).Where(l => l.Raca.Especie.Nome.Equals(especie)).OrderBy(e => e.Nome);

                especieAtual = especie;
            }

            var petListViewModel = new PetListViewModel
            {
                Pets = pets,
                EspecieAtual = especieAtual,
            };

            return View(petListViewModel);

        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Pet> pets;
            string especieAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                pets = _context.Pets.OrderBy(p => p.PetId);
                especieAtual = "Todas as Espécies";
            }

            else 
            {
                pets = _context.Pets.Include(u=>u.Usuario).Where(p => p.Raca.Especie.Nome.ToLower().Contains(searchString.ToLower()) ||
                    p.Raca.Nome.ToLower().Contains(searchString.ToLower()));


                if (pets.Any()) 
                    especieAtual = "Pets encontrados com essa especificação"; 
                else
                    especieAtual = "Nenhum pet foi encontrado. Por favor, verifique se sua especificação está escrita corretamente, respeitando os acentos, e se é uma raça ou uma espécie de pet!";
            }

           
            return View("~/Views/Pet/List.cshtml", new PetListViewModel
            {
                Pets = pets,
                EspecieAtual = especieAtual
            });
        }

        public IActionResult List(int petId)
        {
            var pet = _context.Pets.FirstOrDefault(p => p.PetId == petId);
            return View(pet);
        }

    }
}
