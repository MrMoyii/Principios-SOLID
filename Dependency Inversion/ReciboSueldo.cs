using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class ReciboSueldo
    {
        public ReciboSueldo(int legago, double total)
        {
            Legago = legago;
            Total = total;
        }

        public double Total { get; set; }
        public int Legago { get; set; }
    }
    
}
