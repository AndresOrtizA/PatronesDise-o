using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    public class Originator
    {
        private Multiplicacion _opera;

        public Memento SetOperacion(Multiplicacion pOpera)
        {
            Memento me = new Memento(pOpera);
            _opera = pOpera;
            return me;
        }


        public Multiplicacion GetOperacion()
        {
            return _opera;
        }


        public void OperacionAnterior(Memento operaAnterior)
        {
            _opera = operaAnterior.GetOperacion();
        }
    }
}
