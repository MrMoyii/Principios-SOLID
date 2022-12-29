using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    internal class Impresora
    {
        public void Imprimir(IImprimible imprimible)
        {
            //La Impresora llama al metodo Imprimir de la clase que implemente la interfaz Imprimible pasado por parametro.
            imprimible.Imprimir();
        }
    }
}
