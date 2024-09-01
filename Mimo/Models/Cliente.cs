using System.ComponentModel.DataAnnotations;

namespace Mimo.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "O email não é válido")]
        [StringLength(100, ErrorMessage = "O email não pode exceder 100 caracteres")]
        public string Email { get; set; }
        [Required]
        [Phone(ErrorMessage = "O número de telefone não é válido")]
        [StringLength(15, ErrorMessage = "O telefone não pode exceder 15 caracteres")]
        public string Telefone { get; set; }

        public ICollection<Pedido>? Pedidos { get; set; }
    }
}
