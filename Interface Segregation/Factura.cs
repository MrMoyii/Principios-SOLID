using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    internal class Factura : Documento
    {
        public Factura(int numero, DateTime fecha) : base(numero, fecha) { }
       
        public string CAI { get; set; }

        ////Est esta mal!!
        //public override void EnviarPorEmail()
        //{
        //   //esta peracion no es valida para factura.
        //}

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiend por email la factura {Numero} del dia {Fecha.ToShortDateString()} con CAI {CAI}");
        }
    }
}
