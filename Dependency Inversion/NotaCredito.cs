using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero, DateTime Fecha, double imprte) : base(numero, Fecha, imprte)
        {
            _sigla = "NC";
        }

        public override double Total()
        {
            return Importe * 1.21 * -1;//Ejemplo
        }
    }
}
