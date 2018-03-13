using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDeDado
{
    class Dado
    {
        private int _caras;
        Random rnd = new Random();

        public Dado()
        {
            _caras = 6;
        }

        public int lanzamiento()
        {
            int r = rnd.Next(1,7);

            return r;
        }
    }
}
