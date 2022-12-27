using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    internal class FacturaElectronica : Documento, IEmaileable
    {
        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha) { }
        
        public string CAE { get; set; }
        public void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando por email la factura {Numero} del dia {Fecha.ToShortDateString()} con CAE {CAE}");

        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiend por email la factura {Numero} del dia {Fecha.ToShortDateString()} con CAE {CAE}");

        }
    }
}
