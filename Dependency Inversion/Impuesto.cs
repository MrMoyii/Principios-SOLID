using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal abstract class Impuesto
    {
        public Impuesto(double importe)
        {
            Importe = importe;
        }
        public double Importe { get; set; }
    }
}
