using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class Remito : IImprimible
    {
        public Remito(int numero, DateTime fecha, int cantBultos)
        {
            Numero= numero;
            Fecha= fecha;
            CantBultos= cantBultos;
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int CantBultos { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo remito {Numero} de fecha {Fecha} con un total de {CantBultos} ");
        }
    }
}
