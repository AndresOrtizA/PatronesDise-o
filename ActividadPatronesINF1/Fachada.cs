using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    /// <summary>
    /// implementamos Patron Fachada para centralizar un grupo de operaciones dividadas
    /// en varios modulos
    /// </summary>
    public class Fachada
    {
               
        public double Sumar(double n1, double n2) {

            return Suma.GetInstance.Operar(n1,n2);
        }

        public double Dividir(double n1, double n2)
        {
            return new Division().Operar(n1, n2);
        }

        public double Multiplicar(double n1, double n2)
        {
            return new Multiplicacion().Operar(n1, n2);
        }

        public double Restar(double n1, double n2)
        {
            return new Resta().Operar(n1, n2);
        }


        public double Porcentual(double n1, double n2)
        {
            return new Multiplicacion().Operar(n1, new Division().Operar(n2, 100));
        }

    }
}
