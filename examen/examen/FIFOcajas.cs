using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class FIFOcajas
    {
        ClaseBasePersonas inicio = null;

        public void push(ClaseBasePersonas nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                ClaseBasePersonas temp = inicio;

                while(temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
        }

        public ClaseBasePersonas peek()
        {
            return inicio;
        }

        public void pop()
        {
            inicio = inicio.Siguiente;
        }

    }
}
