using CustomYourStyle.Entities;

namespace CustomYourStyle.Handler
{
    public class ProductoFactory
    {
        public static Producto CreateProducto(Categoria categoria)
        {
            return categoria.Nombre switch
            {
                "Ropa" => new Ropa(),
                "Accesorio" => new Accesorio(),
                "Calzado" => new Calzado(),
                _ => throw new ArgumentException()
            };
        }
    }
}
