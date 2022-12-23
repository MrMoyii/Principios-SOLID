using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    internal class Remito //: Documento
    {
        public Remito(int numero, DateTime fecha, int bultos) //: base (numero, fecha)
        {
            CantBultos = bultos;
            Numero = numero;
            Fecha = fecha;
        }

        public int CantBultos { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }


        /*Aca es donde se viola el principio de sustitucion de Liskov porque esta
          modificando el comportamiento de una funcion de la clase padre.*/
        public string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos} bultos";
        }
    }
}
