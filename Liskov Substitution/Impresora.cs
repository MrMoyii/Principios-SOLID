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
        public void ImprimirFactura(Remito unaFactura)
        {
            Console.WriteLine(unaFactura.Imprimir());
        }
        public void ImprimirNotaCredito(Remito unaNotaCredito)
        {
            Console.WriteLine(unaNotaCredito.Imprimir());
        }
    }
}
