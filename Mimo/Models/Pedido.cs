using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mimo.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        [Required]
        public DateTime DataPedido { get; set; }

        [Required]
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoTotal { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}