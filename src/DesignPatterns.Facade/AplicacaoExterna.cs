namespace DesignPatterns.Facade
{
    public class AplicacaoExterna
    {
        public IEnumerable<string> TodosOsPedidos() => Pedidos;

        public IEnumerable<string> PedidosPorNome(string nome) => Pedidos.Where(p => p == nome);

        public IEnumerable<string> PedidosPorNomeV2(string nome) => Pedidos.Where(p => p == nome);

        public IEnumerable<string> Top10PedidosPorNome() => Pedidos.Take(10);

        private IEnumerable<string> Pedidos => new List<string> {
                "Pedido1", "Pedido2", "Pedido3",
                "Pedido4", "Pedido5", "Pedido6",
                "Pedido7", "Pedido8", "Pedido9",
                "Pedido10", "Pedido11", "Pedido12",
                "Pedido13", "Pedido14", "Pedido15"
            };
    }
}