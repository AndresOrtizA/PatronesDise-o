using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    public static class Adaptador
    {

        public static double Operar(string pOperador, double n1, double n2) {

            double resultado= 0;

            switch (pOperador)
            {
                case "+":
                    resultado= new Fachada().Sumar(n1,n2);
                    break;
                case "-":
                    resultado = new Fachada().Restar(n1, n2);                    
                    break;
                case "*":
                    resultado = new Fachada().Multiplicar(n1, n2);
                    break;
                case "/":
                    resultado = new Fachada().Dividir(n1, n2);
                    break;
                default:                    
                    break;
            }

            return resultado;

        }

    }
}
