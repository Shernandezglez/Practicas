using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    class Estructura
    {
        
        ClaseBase inicio = null;

        public void agregar(ClaseBase nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                //ClaseBase temp = inicio;
                //while(temp.siguiente != null)
                //{
                //    temp = temp.siguiente;
                //}
                //temp.siguiente = nuevo;
                agregar(nuevo, inicio);


            }
        }

        private void agregar(ClaseBase nuevo, ClaseBase quien)
        {
            if(quien.siguiente != null)
            {
                agregar(nuevo, quien.siguiente);
            }
            else
            {
                quien.siguiente = nuevo;
            }
        }

        public ClaseBase buscar(int dato)
        {
            return null;
        }

        public string listar()
        {
            string cdn = "";
            ClaseBase temp = inicio;

            while(temp != null)
            {
                cdn += temp.ToString() + "\r\n";
                temp = temp.siguiente;
            }

            return cdn;
        }
    }
}
