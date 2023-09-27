using PetZone.Models;

namespace PetZone.ViewModels
{
    public class PetListViewModel
    {
        public IEnumerable<Pet> Pets { get; set; }
        public string EspecieAtual { get; set; }
        public string RacaAtual { get; set; }
    }
}
