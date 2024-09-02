using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mimo.Models
{
    public class ItemPedido
    {
        [Key] // Chave primária
        public int ItemPedidoId { get; set; }

        [Required] // Campo obrigatório
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser pelo menos 1.")]
        public int Quantidade { get; set; }

        [Required] // Campo obrigatório
        [Column(TypeName = "decimal(18,2)")] // Define o tipo de dado no banco como decimal com 18 dígitos e 2 casas decimais
        public decimal PrecoTotal { get; set; }

        [ForeignKey("Pedido")] // Define a chave estrangeira para a entidade Pedido
        [Required] // Campo obrigatório
        public int PedidoId { get; set; }

        // Propriedade de navegação para Pedido
        public Pedido? Pedido { get; set; }

        [ForeignKey("Produto")] // Define a chave estrangeira para a entidade Produto
        [Required] // Campo obrigatório
        public int ProdutoId { get; set; }

        // Propriedade de navegação para Produto
        public Produto? Produto { get; set; }
    }
}
