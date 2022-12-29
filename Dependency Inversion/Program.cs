using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --------------------Teoría--------------------*/
            /*  
                Se utiliza para DESACOPLAR MÓDULOS de software.
                
                Las CLASES DE ALTO NIVEL no deberían depender de las clases
                de bajo nivel. Ambas deberían DEPENDER DE LAS ABSTRACCIONES.

                Las ABSTRACCIONES NO DEBERÍAN DEPENDER DE LOS DETALLES. Los
                detalles deberían depender de las abtracciones.

                Al diseñar la interacción entre un MÓDUL DE ALT NIVEL Y 
                UNO DE BAJO NIVEL, la interacción debe considerarse UNA 
                INTERACCIÓN ABTRACTA entre ellos.

                "Lo que hace es revertir las dependencias para lograr
                un mejor acoplamiento y una mejor cohesion."
            */
            /* --------------------Teoría--------------------*/

            Impresora impresora = new Impresora();

            Factura factura = new Factura(1234, DateTime.Now, 303);
            NotaCredito notaCredito = new NotaCredito(344, DateTime.Now, 400);
            Remito remito = new Remito(5551, DateTime.Now, 5);
            FacturaLuz facturaLuz = new FacturaLuz(441, "444545");
            Municipal municipal = new Municipal(1221, "55555662");

            impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);
            impresora.Imprimir(remito);
            impresora.Imprimir(facturaLuz);
            impresora.Imprimir(municipal);

            Console.ReadKey();
        }
    }
}
