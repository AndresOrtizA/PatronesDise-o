using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    class Program
    {
        /// <summary>
        /// Aplicacion para realizar operaciones matematicas (+, - , * y /)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            //// Solicita la operacion a realizar:
            Console.WriteLine("Digite la Operacion: (+,-,*,/)");
            string signo = Console.ReadLine();

            // se implementa Adaptador
            Adaptador adaptador = new Adaptador();

            // Se implementa Bucle para realizar varias operaciones
            while (true)
            {

                Console.WriteLine("Digite el primer numero:");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite el segundo numero:");
                double n2 = Convert.ToDouble(Console.ReadLine());

                // se imprime el resultado
                Console.WriteLine(string.Format("Resultado:{0}", adaptador.Operar(signo, n1, n2)));

                // se pregunta al usuario si quiere seguir operando
                Console.WriteLine("desea realizar otra operacion? (Y/N)");
                if (Console.ReadLine().ToUpper() != "Y")
                    break;               

            }
            
             
        }
    }
}
