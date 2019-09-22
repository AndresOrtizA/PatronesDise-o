using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    public class Memento
    {
        private Multiplicacion _operacion;

        public Memento(Multiplicacion pOpera)
        {
            _operacion = pOpera;
        }

        public Multiplicacion GetOperacion()
        {
            return _operacion;
        }

    }
}
