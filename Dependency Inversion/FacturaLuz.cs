using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class FacturaLuz : Impuesto
    {
        public FacturaLuz(double importe, string coodigoPago) : base(importe)
        {
            CoodigoPago = coodigoPago;
        }
        public string CoodigoPago { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura de luz con código de pago nro {CoodigoPago} con un importe de {Importe}");
        }
    }
}
