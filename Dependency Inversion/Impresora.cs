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
            Console.WriteLine($"Imprimiendo factura {factura.Numero} del {factura.Fecha} por un importe de {factura.Importe}");
        }
        public void Imprimir(NotaCredito notaCredito)
        {
            Console.WriteLine($"Imprimiendo nota de credito {notaCredito.Numero} del {notaCredito.Fecha} por un importe de {notaCredito.Importe}");
        }
        public void Imprimir(FacturaLuz facturaLuz)
        {
            Console.WriteLine($"Imprimiendo factura de luz con código de pago nro {facturaLuz.CoodigoPago} con un importe de {facturaLuz.Importe}");
        }
        public void Imprimir(Municipal municipal)
        {
            Console.WriteLine($"Imprimiendo impuest municipal de partida {municipal.Partida} por un importe de {municipal.Importe}");
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
