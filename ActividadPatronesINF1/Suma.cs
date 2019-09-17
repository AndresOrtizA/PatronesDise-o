using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesINF1
{
    public class Suma
    {        
        private static Suma _instance = null;
        private static readonly object padlock = new object();

        /// <summary>
        /// Implementamos patron singleton seguro 
        /// haciendo privado el construccion y entregando una unica instancia en el metodo GetInstance
        /// </summary>
        private Suma() { }

        public static Suma GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Suma();
                        }
                    }
                }
                return _instance;
            }
        }

        public double Operar(double n1, double n2)
        {
            return n1 + n2;
        }

    }
    
}
