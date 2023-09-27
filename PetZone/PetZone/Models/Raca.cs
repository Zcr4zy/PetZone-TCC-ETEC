using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetZone.Models
{
    [Table("Raca")]
    public class Raca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RacaId { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome da raça do animal deve ser informado!")]
        [MaxLength(60, ErrorMessage = "O nome da raça do pet pode possuir no máximo 60 caracteres!")]
        public string Nome { get; set; }


        [Required]
        public int EspecieId { get; set; }
        [ForeignKey("EspecieId")]
        public Especie Especie { get; set; }

    }
}