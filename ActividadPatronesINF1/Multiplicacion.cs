using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    public class Multiplicacion
    {
        public double Numero1 { get; set; }

        public double Numero2 { get; set; }

        public double Resultado { get; set; }

        public Multiplicacion(double pNumero1, double pNumero2)
        {
            Numero1 = pNumero1;
            Numero2 = pNumero2;
        }

        public double Operar()
        {
            Resultado = Numero1 * Numero2;
            return Resultado;
        }
    }
}
