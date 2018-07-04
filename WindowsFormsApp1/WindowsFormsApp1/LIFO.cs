using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class LIFO
    {
        public ClaseNumeros start,ultimo = null;

        public void encolarLifo(ClaseNumeros nuevo)
        {
            if (start == null)
            {
                start = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ClaseNumeros t = start;

                while (t.Siguiente != null)
                {
                    t = t.Siguiente;
                }
                t.Siguiente = nuevo;
                ultimo = t.Siguiente;
            }
        }

        public ClaseNumeros verLifo()
        {
            ClaseNumeros temp = start;

            while(temp.Siguiente != null)
            {
                temp = temp.Siguiente;
                
            }
            return temp;
           
        }

        public void pop()
        {
            ClaseNumeros temp = start;

            while (temp.Siguiente != null)
            {
                if(temp.Siguiente.Siguiente == null)
                {
                    break;
                }
                temp = temp.Siguiente;
            }

            ultimo = temp;

        }

        
    }
}
