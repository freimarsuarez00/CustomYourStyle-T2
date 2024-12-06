using CustomYourStyle.Entities;
using CustomYourStyle.Entities.Constants;
using CustomYourStyle.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomYourStyle.Repository
{
    public  class PedidoRepository
    {
        private readonly List<Pedido> _pedidoList = [];
        private int _id = 0;
        public PedidoRepository() { }
        public int AddPedido(Pedido pedido)
        {
            _id++;
            pedido.IdPedido = _id;
            pedido.Estado = Estados.Pendiente.ToString();
            _pedidoList.Add(pedido);
            return pedido.IdPedido;
        }
        public string UpdateEstadoPedido(int idPedido, string estado)
        {
            var pedido = _pedidoList.FirstOrDefault(p => p.IdPedido == idPedido);
            pedido.Estado = estado;
            return $"Se ha actualizado el pedido {pedido.IdPedido} a {pedido.Estado}";
        }
        public List<Pedido> GetAllPedidos() { return _pedidoList; }

    }
}
