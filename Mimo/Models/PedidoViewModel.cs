namespace Mimo.Models
{
    public class PedidoViewModel
    {
        public DateTime DataPedido { get; set; }
        public int ClienteId { get; set; }
        public List<ItemPedidoViewModel> ItensPedido { get; set; } = new List<ItemPedidoViewModel>();

        public List<Cliente> Clientes { get; set; } // Populado no Controller
        public List<Produto> Produtos { get; set; } // Populado no Controller
    }

    public class ItemPedidoViewModel
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoTotal { get; set; }
    }
}
