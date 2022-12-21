using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --------------------Teoría--------------------*/
            /*  
                Una clase solo debe tener una razón para cambiar(responsabilidad).
             
                Una responsabilidad tiene que ver con
                * ¿Qué hace?
                * ¿A quién conoce?
            
                Se centra en mantener alta la cohesión.

                Cada clase debe tener responsabilidad sobre una sola parte de la
                funcionalidad proporcionada por el software, y esa responsabilidad
                debe estar completamente encapsulada por la clase.
            */
            /* --------------------Teoría--------------------*/

            /*Lo que hacemos es sacar la responsabilidad de la Factura
              creando una clase cliente para luego pasarla por parametros.*/


            Cliente cliente = new Cliente();
            cliente.Apellido = "Lopez";
            cliente.Nombre = "Diego";

            Factura factura = new Factura(123, cliente);

            /*Así era como estaba antes, se agregaban los datos 
              del cliente por parametro al constructor.*/

            //Factura factura = new Factura(123, "Diego", "Lopez");


            Item i1 = new Item(new Producto("Arroz", 10), 5);
            Item i2 = new Item(new Producto("Pan", 90), 1);
            Item i3 = new Item(new Producto("Fideos", 70), 2);

            factura.Items.Add(i1);
            factura.Items.Add(i2);
            factura.Items.Add(i3);

            Console.WriteLine("Precio Total: $" + factura.Total());
            Console.ReadKey();

        }
    }
}
