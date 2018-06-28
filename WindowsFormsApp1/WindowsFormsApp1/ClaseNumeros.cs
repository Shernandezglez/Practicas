using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ClaseNumeros
    {
        private int _num;
        private ClaseNumeros _siguiente;

        public ClaseNumeros(int num)
        {
            _num = num;
        }

        public int Numero
        {
            get { return _num; }
            set { _num = value; }
        }

        public ClaseNumeros Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public override string ToString()
        {
            return "Num: " + _num;
        }
    }
}
