using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    internal class Impresora
    {
        public void ImprimirRemito(Remito unRemito)
        {
            Console.WriteLine(unRemito.Imprimir());
        }
        public void ImprimirFactura(Factura unaFactura)
        {
            Console.WriteLine(unaFactura.Imprimir());
        }
        public void ImprimirNotaCredito(NotaCredito unaNotaCredito)
        {
            Console.WriteLine(unaNotaCredito.Imprimir());
        }
    }
}
