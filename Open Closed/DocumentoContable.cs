using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    /*Aca samos el enum del TipoDocumentoContable y le delegamos la tarea de
     decirno que tipo es a cada tipo de documento contable.*/

    /*Entonces hacemos esta clase y metodo abstractos para que luego en cada
     clase que se herede de esta, implemente su logica.*/
    internal abstract class DocumentoContable
    {
        
        public DocumentoContable(int numero)
        {
            Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        public abstract string Descripcion();
    }
}
