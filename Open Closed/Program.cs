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
            DocumentoContable unaFactura = new DocumentoContable(TipoDocumentoContable.Factura, 55532);
            Console.WriteLine(unaFactura.Descripcion());

            DocumentoContable unaNotaCredito = new DocumentoContable(TipoDocumentoContable.NotaCredito, 55532);
            Console.WriteLine(unaNotaCredito.Descripcion());

            Console.ReadKey();
        }
    }
}
