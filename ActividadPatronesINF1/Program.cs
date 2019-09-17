using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Digite la Operacion:");
            string signo = Console.ReadLine();

            Console.WriteLine("Digite el primer numero:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero:");
            double n2 = Convert.ToDouble(Console.ReadLine());            

            Console.WriteLine(string.Format("Resultado:{0}", Adaptador.Operar(signo,n1,n2)));

            Console.ReadKey();
             
        }
    }
}
