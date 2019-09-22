using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    /// <summary>
    /// Se implementa Adaptador , ya que la fachada opera por Metodos y el usuario Teclea singnos.
    /// </summary>
    public class Adaptador
    {

        private Fachada _fachada = new Fachada();

        /// <summary>
        /// Dependiendo del Operador entrante se usa un metodo diferente de la fachada.
        /// </summary>
        /// <param name="pOperador"></param>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public double Operar(string pOperador, double n1, double n2) {

            double resultado= 0;

            switch (pOperador)
            {
                case "+":
                    resultado= _fachada.Sumar(n1,n2);
                    break;
                case "-":
                    resultado = _fachada.Restar(n1, n2);                    
                    break;
                case "*":
                    resultado = _fachada.Multiplicar(n1, n2);
                    break;
                case "/":
                    resultado = _fachada.Dividir(n1, n2);
                    break;
                default:                    
                    break;
            }

            return resultado;

        }

    }
}
