using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class ReciboSueldo
    {
        public ReciboSueldo(int legajo, double total)
        {
            Legajo = legajo;
            Total = total;
        }

        public double Total { get; set; }
        public int Legajo { get; set; }
    }
    
}
