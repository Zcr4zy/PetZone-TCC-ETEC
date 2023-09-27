using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetZone.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GeneroId { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do gênero deve ser informado!")]
        [MaxLength(50, ErrorMessage = "O nome do gênero pode conter no máximo 50 caracteres!")]
        public string Nome { get; set; }

    }
}