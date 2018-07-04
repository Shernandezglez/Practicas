using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ClaseCaracteres
    {

        private char _exp;
        private ClaseCaracteres _siguiente;

        public ClaseCaracteres(char exp)
        {
            _exp = exp;
        }



        public char Expresion
        {
            get { return _exp; }
            set { _exp = value; }
        }

        public ClaseCaracteres Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public override string ToString()
        {
            return "" + _exp;
        }

    }
}
