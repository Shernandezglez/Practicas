using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class EstructuraListaDoble
    {

        ClaseBaseCaja inicio = null, ultimo = null;

        public void agregar(ClaseBaseCaja nuevo)
        {
            ClaseBaseCaja temp = inicio;
            if(inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
            }
            else if(nuevo.caja < inicio.caja)
            {
                nuevo.Siguiente = inicio;
                inicio.Anterior = nuevo;
                inicio = nuevo;
            }
            else if(nuevo.caja > ultimo.caja)
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = nuevo;
                ultimo = nuevo;
            }
            else
            {
                while(nuevo.caja > temp.caja)
                {
                    temp = temp.Siguiente;
                }

                nuevo.Anterior = temp.Anterior;
                nuevo.Siguiente = temp;
                temp.Anterior.Siguiente = nuevo;
                temp.Anterior = nuevo;
            }
        }



    }
}
