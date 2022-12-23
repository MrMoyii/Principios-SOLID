using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --------------------Teoría--------------------*/
            /*  
                Este principio se vasa en tratar de mantener la herarquia de las 
                clases de tal manera que el sentido de elllas sea correcto.
                
                EXTENSIÓN del principio OPEN/CLOSED.
                
                Una CLASE DERIVADA puede ser REEMPLAZADA por cualquier OTRA QUE USE
                SU CLASE BASE sin ALTERAR el correcto FUNCIONAMIENTO de un programa.

                Si una función espera como PARÁMETRO UNA CLASE BASE esta puede ser 
                REEMPLAZADA POR CUALQUIER clase derivada.
                
                Una SUBCLASE NO DEBE REMOVER NI MODICAR COMPORTAMIENTO de la clase
                base, NO DEBE CONOCER a los demas SUBTIPOS. 
                
                Si un SUBTIPO HACE ALGO QUE EL CLIENTE DEL SUPERTIPO NO ESPERA, es
                una VIOLACIÓN al principio.
            */
            /* --------------------Teoría--------------------*/

            Impresora impresora = new Impresora();

            Remito rto = new Remito(3331, DateTime.Now,10);
            DocumentoContable fc = new Factura(66423, DateTime.Now);
            DocumentoContable nc = new NotaCredito(441, DateTime.Now);
            DocumentoContable nd = new NotaDebito(345, DateTime.Now);

            /*Si todos los metodos de documento que utilizo me sirven
              es correcta la declaracion y es correcta el uso del
              principio de sustitucion de Liskov.
              Si yo tuviera que usar un metodo de una clase derivada
              que no sea parte de la clase documento, no estaria 
              respetando este principio.*/


            impresora.ImprimirRemito(rto);
            impresora.ImprimirDocumento(fc);
            impresora.ImprimirDocumento(nc);
            impresora.ImprimirDocumento(nd);

            Console.ReadKey();

        }
    }
}
