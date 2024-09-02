using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mimo.Models
{
    public class Pedido
    {
        [Key] // Chave primária
        public int PedidoId { get; set; }

        [Required] // Campo obrigatório
        public DateTime DataPedido { get; set; }

        [ForeignKey("Cliente")] // Define a chave estrangeira para a entidade Cliente
        [Required] // Campo obrigatório
        public int ClienteId { get; set; }

        // Propriedade de navegação para Cliente
        public Cliente? Cliente { get; set; }

        // Navegação para Itens do Pedido
        public ICollection<ItemPedido>? ItensPedido { get; set; }
    }
}