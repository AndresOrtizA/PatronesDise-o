using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    /// <summary>
    /// implementamos Patron Fachada para centralizar un grupo de operaciones dividadas
    /// en varios modulos (clases)
    /// </summary>
    public class Fachada
    {

        // CARETAKER FOR MEMENTO
        IList<Memento> operacionesAnteriores = new List<Memento>();
        Originator orig = new Originator();
        
        public Fachada()
        {
                
        }
               
        public double Sumar(double n1, double n2) {
            
            // Se llama la instancia para la clase Suma (Singleton)            
            return Suma.GetInstance.Operar(n1,n2);
        }

        public double Dividir(double n1, double n2)
        {
            return new Division().Operar(n1, n2);
        }

        public double Multiplicar(double n1, double n2)
        {
            
            // Se implementa patron Memento
            // Si la calculadora ya realizo la misma operacion previamente, retorna el resultado encontrado.

            // valida si es la primera iteracion, de lo contrario procede a buscar la operacion
            if (operacionesAnteriores.Count>0)
            {
                foreach (var item in operacionesAnteriores)
                {
                    orig.OperacionAnterior(item);
                    Multiplicacion op = orig.GetOperacion();

                    // Si encuentra que ya se resolvio esa misma operacion anteriormente, retorna el resultado
                    if (op.Numero1== n1 && op.Numero2 == n2)
                    {
                        return op.Resultado;
                    }

                }
            }

            // Si la operacion no fue encontrada , la resuelve y la Agrega al Memento
            Multiplicacion operacion = new Multiplicacion(n1, n2);
            operacionesAnteriores.Add(orig.SetOperacion(operacion));
            return operacion.Resultado;
        }

        public double Restar(double n1, double n2)
        {
            return new Resta().Operar(n1, n2);
        }        

    }
}
