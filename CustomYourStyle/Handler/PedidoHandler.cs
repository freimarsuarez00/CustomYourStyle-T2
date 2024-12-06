using CustomYourStyle.Entities;
using CustomYourStyle.Repository;


namespace CustomYourStyle.Handler
{
    public class PedidoHandler
    {
        private PedidoRepository _pedidoRepository;
        private static PedidoHandler? _instancia;

        // Constructor privado que recibe el PedidoRepository
        private PedidoHandler(PedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        // Propiedad estática para obtener la instancia única de PedidoHandler
        public static PedidoHandler Instancia(PedidoRepository pedidoRepository)
        {
            if (_instancia == null)
            {
                _instancia = new PedidoHandler(pedidoRepository);
            }
            return _instancia;
        }

        // Método para agregar un pedido
        public int AddPedido(Pedido pedido)
        {
            return _pedidoRepository.AddPedido(pedido);
        }

        // Método para actualizar el estado de un pedido
        public void ActualizarEstadoPedido(int pedidoId, string nuevoEstado)
        {
            _pedidoRepository.UpdateEstadoPedido(pedidoId, nuevoEstado);
        }

        public List<Pedido> GetAllPedidos()
        {
            return _pedidoRepository.GetAllPedidos();
        }

        

    }

}
