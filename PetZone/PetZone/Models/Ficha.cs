using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetZone.Models
{
    [Table("Ficha")]
    public class Ficha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FichaId { get; set; }

        [Required(ErrorMessage = "Por favor, informe o seu CPF!")]
        [MaxLength(14,ErrorMessage ="Este campo possui um máximo de 14 caracteres!")]
        [MinLength(11,ErrorMessage ="Este campo possui um mínimo de 11 caracteres!")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe a sua Renda Mensal!")]
        [Display(Name = "Renda Mensal")]
        public decimal Renda { get; set; }

        [Required(ErrorMessage = "O motivo da adoção tem que ser informada!")]
        [StringLength(200)]
        [Display(Name = "Motivo da Adoção")]
        public string Motivo { get; set; }

        [Display(Name = "Data do Pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime PedidoEnviado { get; set; } = DateTime.Now;

        [Required]
        public string UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Required]
        public int PetId { get; set; }
        [ForeignKey("PetId")]
        public Pet Pet { get; set; }

    }
}
