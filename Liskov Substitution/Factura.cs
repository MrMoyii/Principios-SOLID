using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    internal class Factura : Documento
    {
        public Factura(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "FC";
        }
    }
}
