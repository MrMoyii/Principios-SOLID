using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsability
{
    internal class Producto
    {
        public Producto(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }

        public string Descripcion { get; set; }
        public double Precio { get; set; }

    }
}
