using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    class ClaseBase
    {
        private int _dato;
        private ClaseBase _siguietne;

        public int Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public ClaseBase siguiente
        {
            get { return _siguietne; }
            set { _siguietne = value; }
        }


        public ClaseBase(int dato)
        {
            _dato = dato;
        }

        public override string ToString()
        {
            return "dato = " + _dato;
        }


    }
}
