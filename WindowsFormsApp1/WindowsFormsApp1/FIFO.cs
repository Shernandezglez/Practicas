using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FIFO
    {

        public ClaseCaracteres inicio = null;


        public void encolarFifo(ClaseCaracteres nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                ClaseCaracteres temp = inicio;

                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
        }

        public ClaseCaracteres peek()
        {
            return inicio;
        }

        public void pop()
        {
           
            inicio = inicio.Siguiente;
        }
    }
}
