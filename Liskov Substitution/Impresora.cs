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
        /*Aca simplificamos para que impresora reciba un documento
          y asi podemos respetar la herarquia, asiendo que no importa
          que docuento contable se reciba, este puede imprimirse.*/
        public void ImprimirDocumento(DocumentoContable unaDocumento)
        {
            Console.WriteLine(unaDocumento.Imprimir());
        }

        
        //public void ImprimirNotaCredito(NotaCredito unaNotaCredito)
        //{
        //    Console.WriteLine(unaNotaCredito.Imprimir());
        //}
    }
}
