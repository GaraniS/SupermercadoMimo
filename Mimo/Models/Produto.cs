using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mimo.Models
{
    public class Produto
    {
        [Key] // Chave primária
        public int ProdutoId { get; set; }

        [Required] // Campo obrigatório
        [StringLength(100, ErrorMessage = "O nome do produto não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required] // Campo obrigatório
        [Column(TypeName = "decimal(18,2)")] // Define o tipo de dado no banco como decimal com 18 dígitos e 2 casas decimais
        public decimal Preco { get; set; }

        // Navegação para Itens do Pedido
        public ICollection<ItemPedido>? ItensPedido { get; set; }
    }
}