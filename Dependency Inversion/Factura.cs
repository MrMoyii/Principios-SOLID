using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class Factura : DocumentoContable
    {
        public Factura(int numero, DateTime Fecha, double imprte) : base(numero, Fecha, imprte)
        {
            _sigla = "FC";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura {Numero} del {Fecha} por un importe de {Importe}");
        }

        public override double Total()
        {
            return Importe * 1.21;
        }
    }
}
