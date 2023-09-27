using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetZone.Models
{
    [Table("Curiosidade")]
    public class Curiosidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CuriosidadeId { get; set; }

        [Required(ErrorMessage = "Informe o nome desta curiosidade!")]
        public string Nome { get; set; }


        [Required(ErrorMessage="Informe a descricao da curiosidade!")]
        public string Descricao { get; set; }


        public string Imagem { get; set; }


        [Required]
        public int RacaId { get; set; }
        [ForeignKey("RacaId")]
        public Raca Raca { get; set; }

    }
}
