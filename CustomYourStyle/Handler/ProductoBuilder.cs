﻿using CustomYourStyle.Entities;

namespace CustomYourStyle.Handler
{
    public class ProductoBuilder
    {
        private Producto _producto;
        public ProductoBuilder(Categoria categoria)
        {
            _producto = ProductoFactory.CreateProducto(categoria);
        }

        public ProductoBuilder SetColorRopa(string color)
        {
            if (_producto is Ropa ropa)
            {
                ropa.Color = color;
            }
            return this;
        }

        public ProductoBuilder SetTallaRopa(string talla)
        {
            if (_producto is Ropa ropa)
            {
                ropa.Talla = talla;
            }
            return this;
        }


        public Producto Build() => _producto;
    }
}
