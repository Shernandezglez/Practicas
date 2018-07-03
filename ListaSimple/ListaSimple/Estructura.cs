using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    class Estructura
    {
        ClaseBase inicio,ultimo = null;

        public void agregar(ClaseBase nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                ClaseBase temp = inicio;

                while(temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }

                temp.Siguiente = nuevo;
                ultimo = temp.Siguiente;
            }
        }

        public void eliminarPrimero()
        {
            inicio = inicio.Siguiente;
        }

        public void eliminarUltimo()
        {
            ClaseBase temp = inicio;

            if (temp.Siguiente == null)
            {
                temp = null;
            }

            while (temp.Siguiente != null)
            {
                temp = temp.Siguiente;

                if(temp.Siguiente.Siguiente == null)
                {
                    break;
                }
            }

            ultimo = temp.Siguiente;
            ultimo.Siguiente = null;
        }


        public string reporte()
        {
            string cdn = "";
            ClaseBase temp = inicio;

            while(temp.Siguiente != null)
            {
                cdn += temp.ToString() + "\r\n";
                temp = temp.Siguiente;
            }

            return cdn;
        }

        public string reporteInverso()
        {
            string cdn = "";
            ClaseBase temp = inicio;

            while (temp != null)
            {
                cdn = temp.ToString() + "\r\n" + cdn;
                temp = temp.Siguiente;
            }

            return cdn;
        }

        public void invertirLista()
        {
            ClaseBase prev = null;
            ClaseBase current = inicio;
            ClaseBase next;

            while(current != null)
            {
                next = current.Siguiente;
                current.Siguiente = prev;
                prev = current.Siguiente;
                current = next;

            }

            inicio = prev;
        }

        public ClaseBase buscarPorContacto(int num)
        {
            ClaseBase temp = inicio;

            while (temp.Siguiente != null)
            {
                temp = temp.Siguiente;

                if (temp.Contacto == num)
                {
                    return temp;
                }
            }
            if (inicio.Contacto == num)
            {
                return inicio;
            }
            else if(ultimo.Contacto == num)
            {
                return ultimo;
            }
            else
                return null;
        }

        public void insertar(int pos)
        {

        }

        public void eliminarPorContacto(int num)
        {

            ClaseBase temp = inicio;

            while(temp.Siguiente != null)
            {
                temp = temp.Siguiente;

                if(temp.Siguiente.Contacto == num)
                {
                    temp.Siguiente = temp.Siguiente.Siguiente;
                     
                }
                
            }
            if(inicio.Contacto == num)
            {
                eliminarPrimero();
            }
            else if(ultimo.Contacto == num)
            {
                eliminarUltimo();
            }
        }
    }
}
