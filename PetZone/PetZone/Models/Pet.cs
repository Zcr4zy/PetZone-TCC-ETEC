using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetZone.Models
{
    [Table("Pet")]
    public class Pet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PetId { get; set; }

        [Display(Name = "Nome")]
        [MaxLength(50, ErrorMessage = "O nome do animal deve possuir no máximo 50 caracteres!")]
        public string Nome { get; set; }

        [Display(Name = "Descricao")]
        [MaxLength(500, ErrorMessage = "A descrição do animal deve possuir no máximo 500 caracteres!")]
        [Required(ErrorMessage = "A descrição do animal é obrigatória!")]
        public string Descricao { get; set; }

        [Display(Name = "Idade")]
        [MaxLength(40, ErrorMessage = "Este campo pode possuir no máximo 40 caracteres!")]
        public string Idade { get; set; }

        [Display(Name = "Peso do Pet")]
        [Column(TypeName = "decimal(6,3)")]
        public decimal Peso { get; set; }

        [Display(Name = "Imagem")]
        public string ImgLink { get; set; }

        [Display(Name = "ImagemII")]
        public string ImgLinkII { get; set; }

        [Required]
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

        [Required]
        public int RacaId { get; set; }
        [ForeignKey("RacaId")]
        public Raca Raca { get; set; }

        [Required]
        public string UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public bool ParaAdocao { get; set; }

    }
}