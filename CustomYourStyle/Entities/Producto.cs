using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomYourStyle.Entities
{
    public abstract class Producto
    {
        public int IdProducto { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
        public Categoria Categoria { get; set; }
        public abstract Producto Clonar();
    }
}
