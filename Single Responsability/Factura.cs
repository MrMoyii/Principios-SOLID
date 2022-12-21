using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsability
{
    internal class Factura
    {
        /*Aca sacamos los paramos de nombre y apellido,
          para que eso se ocupe la clase cliente.*/
        public Factura(int numero, Cliente cliente) 
        {
            Numero = numero;
            Cliente = cliente;
            //Nombre = nombre;
            //Apellido = apellido;
            Items = new List<Item>();
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente{ get; set; }
        
        public List<Item> Items { get; set; }

        /*Aca delegamos la tarea de calcular el precio de cada procuto
          a la clase Item con el metodo Subtoal.*/
        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Subtotal();
                //total += item.Cantidad * item.Producto.Precio;
            }
            return total;
        }

    }
}
