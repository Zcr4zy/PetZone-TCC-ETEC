using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetZone.Models
{
    [Table("Especie")]
    public class Especie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EspecieId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome da espécie do animal deve ser informado!")]
        public string Nome { get; set; }

    }
}