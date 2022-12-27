using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --------------------Teoría--------------------*/
            /*  
                Los CLIENTES no deben estar FORZADOS a IMPLEMENTAR INTERFACES
                QUE NO USAN.

                Guarda relación cno la COHESIÓN de las aplicacionoes.

                Las clases que implementen una interface oo una clase abstracta
                NO DEBERÍAN ESTAR OBLIGADOS A UTILIZAR PARTES QUE NO VAN A UTILIZAR.

                Los CLIENTES NO DEBEN ESTAR OBLIGADS A IMPLEMENTAR y/ a depender
                de una INTERFACE QUE LUEGO NO USARÁN.
            */
            /* --------------------Teoría--------------------*/

            Factura factura = new Factura(12344, DateTime.Now);
            factura.CAI = "234324324";

            FacturaElectronica facturaElectronica = new FacturaElectronica(12344, DateTime.Now);
            facturaElectronica.CAE = "666345444";

            facturaElectronica.Imprimir();
            facturaElectronica.EnviarPorEmail();
            factura.Imprimir();
            //factura.EnviarPorEmail(); //Esto es un errror y se debe evitar.

            Console.ReadKey();
        }
    }
}
