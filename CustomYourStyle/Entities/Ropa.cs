using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomYourStyle.Entities
{
    public class Ropa : Producto
    {
        public int IdRopa { get; set; }
        public string? Color { get; set; }
        public string? Talla { get; set; }
        public int TelaId { get; set; }
        public Tela Tela { get; set; }
        public int? MarcaId { get; set; }
        public Marca Marca { get; set; }

        public override Producto Clonar()
        {
            return (Producto)this.MemberwiseClone();
        }

    }
}
