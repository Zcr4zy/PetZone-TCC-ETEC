using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PetZone.Models
{
    public class Usuario : IdentityUser
    {
        [Required(ErrorMessage = "Por favor informe o seu Nome!")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor informe o seu CEP!")]
        [StringLength(10, MinimumLength = 8)]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Por favor informe o seu Endereço!")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Por favor informe o seu número")]
        [StringLength(100)]
        [Display(Name = "Número")]
        public string Numero { get; set; }

        [StringLength(60)]
        public string Cidade { get; set; }

        [StringLength(2)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe a sua Data de Nascimento!")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Imagem")]
        public string Foto { get; set; }
    }
}
