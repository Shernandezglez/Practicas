using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monedis
{
    class LanzamientoDeMoneda
    {
        Random rnd = new Random();
        public int r;

        public void lanzamientoMoneda()
        {
           r = rnd.Next(0, 2);
            
        }

        public int getResultado
        {
            get { return r; }
            
        }


    }
}
