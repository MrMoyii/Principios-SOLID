using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    internal abstract class DocumentoContable
    {
        protected string _sigla;
        public DocumentoContable(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }
        public virtual string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}
