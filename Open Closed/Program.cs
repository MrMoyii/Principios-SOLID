using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --------------------Teoría--------------------*/
            /*  
                El COMPORTAMIENTO de una entidad debe poder ser ALTERADO
                SIN TENER QUE MODIFICAR SU PROPIO CÓDIGO FUENTE.
             
                Una CLASE NO SE PUEDE MODIFICAR, PERO SI SE PUEDE EXTENDER
                haciaendo uso de la herencia.

                Una clase SOLO DEBE SER MODIFICADA SI EXISTE UN BUG, para no
                romper funcionalidades en módulos dependientes.
            
                Se centra en MANTENER BAJO AL ACOPLAMIENTO.
            */
            /* --------------------Teoría--------------------*/


            DocumentoContable unaFactura = new Factura(12331);
            Console.WriteLine(unaFactura.Descripcion());

            DocumentoContable unaNotaCredito = new NotaCredito(22314);
            Console.WriteLine(unaNotaCredito.Descripcion());


            /*Ahora cuando tengamos que agregar un nuevo tipo de documento contable
              solo debemos crear la clase y hacer que herede de DocumentoContable*/
            DocumentoContable unaNotaDebito = new NotaDebito(42314);
            Console.WriteLine(unaNotaDebito.Descripcion());

            Console.ReadKey();
        }
    }
}
