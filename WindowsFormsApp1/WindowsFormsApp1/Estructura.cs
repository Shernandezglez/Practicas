using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Estructura
    {
        //FIFO
        public ClaseCaracteres inicio = null;
        public ClaseNumeros start = null;

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

        //LIFO

        public void encolarLifo(ClaseNumeros nuevo)
        {
            if (start == null)
            {
                start = nuevo;
            }
            else
            {
                ClaseNumeros t = start;

                while (t.Siguiente != null)
                {
                    t = t.Siguiente;
                }
                t.Siguiente = nuevo;
            }
        }

        public ClaseNumeros verLifo()
        {
            ClaseNumeros temp = start;

            while (temp.Siguiente != null)
            {
                if (temp.Siguiente == null)
                {
                    break;
                }
            }

            return temp.Siguiente;
        }

        public void desencolar()
        {
            ClaseNumeros temp = start;

            while (temp.Siguiente != null)
            {
                if (temp.Siguiente == null)
                {
                    break;
                }
            }
            temp.Siguiente.Siguiente = temp.Siguiente;

        }
    }
}
