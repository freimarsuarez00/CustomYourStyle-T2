using CustomYourStyle.Entities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomYourStyle.Entities
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> Productos { get; set; } = [];
    }
}
