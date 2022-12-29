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
    }
}
