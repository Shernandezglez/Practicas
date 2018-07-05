using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class ClaseBasePersonas
    {
        Random rnd = new Random();
        public int _ciclos;
        private ClaseBasePersonas _siguiente;


        public ClaseBasePersonas()
        {
            _ciclos = rnd.Next(3, 11);

        }

        public ClaseBasePersonas Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public override string ToString()
        {
            return "Ciclos : " + _ciclos; 
                
        }
    }
}
