using CustomYourStyle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomYourStyle.Handler
{
    public class ProductoPrototype
    {
        private Producto _productoOriginal;

        public ProductoPrototype(Producto productoOriginal)
        {
            _productoOriginal = productoOriginal;
        }

        public Producto Clonar()
        {
            return _productoOriginal.Clonar();
        }
    }
}
