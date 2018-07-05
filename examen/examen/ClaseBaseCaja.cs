using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class ClaseBaseCaja
    {

        private int _caja;
        private int _personas;
        private ClaseBaseCaja _siguiente;
        private ClaseBaseCaja _anterior;

        public int caja
        {
            get { return _caja; }
            set { _caja = value; }
        }

        public int PersonasAtendiendo
        {
            get { return _personas; }
            set { _personas = value; }
        }

        public ClaseBaseCaja Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public ClaseBaseCaja Anterior
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public ClaseBaseCaja(int cja)
        {
            _caja = cja;
        }

        public override string ToString()
        {
            return "Caja: " + _caja;
        }
    }
}
