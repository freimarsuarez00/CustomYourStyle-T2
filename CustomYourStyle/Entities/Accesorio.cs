using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomYourStyle.Entities
{
    public class Accesorio : Producto
    {
        public DateTime FechaElaboracion { get; set; }
        public string Material { get; set; }

        public override Producto Clonar()
        {
            return (Producto)this.MemberwiseClone();
        }
    }
}
