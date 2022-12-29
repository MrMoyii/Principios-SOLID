using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class Impresora
    {
        public void Imprimir(Factura factura)
        {
            
        }
        public void Imprimir(NotaCredito notaCredito)
        {
            
        }
        public void Imprimir(FacturaLuz facturaLuz)
        {
            
        }
        public void Imprimir(Municipal municipal)
        {
            
        }
        public void Imprimir(ReciboSueldo reciboSueldo)
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {reciboSueldo.Legajo} por ");
        }
        public void Imprimir(Remito remito)
        {
            Console.WriteLine($"Imprimiendo remito {remito.Numero} de fecha {remito.Fecha} con un total de {remito.CantBultos} ");
        }
    }
}
