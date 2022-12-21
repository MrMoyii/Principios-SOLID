using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsability
{
    internal class Item
    {
        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }


        /*Aca creamos un metodo para que calcule el SubTotal de cada Producto
          para delegar esta responsabildiad de la factura.*/
        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}
