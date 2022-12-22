using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    internal class NotaDebito : DocumentoContable
    {
        /*Agregamos esta nueva clase y vemos que simplemente tenemos
          que implementar el metodo de la clase abstracta del padre.*/
        public NotaDebito(int numero) : base(numero)
        {

        }

        public override string Descripcion()
        {
            return $"ND--{Numero}";
        }
    }
}
