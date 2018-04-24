using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasConArreglos
{
    class Inventario
    {
        private Producto[] _pro;
        private int total;

        public Inventario(int nPro)
        {
            _pro = new Producto[nPro];
            total = 0;
        }


        public void agregarProducto(Producto pro)
        {

            //for (int i = total - 1; i > 0 + 1; i--)
            //{
            //    _pro[i] = _pro[i - 1];
            //}
            _pro[total++] = pro;
        }

        public Producto buscar(int cod)
        {
            for (int i = 0; i < total-1; i++)
            {
                if (_pro[i].codigo == cod)
                {
                    return _pro[i];
                }
               
            }

            return null;
        }

        public void eliminarProducto(int cod)
        {
            for(int i = 0; i < total -1; i++)
            {
                if (_pro[i].codigo == cod)
                {
                    _pro[i] = null;
                }
                   
            }
        }

        public void insertarProducto(Producto p, int pos)
        {
            _pro[pos] = p;
        }

        public string listarProductos()
        {
            string cosa = "";
            for (int i = 0; i < total; i++)
                if (_pro[i] != null)
                    cosa +=_pro[i].ToString() + "\r\n";
                   
            return cosa;
        }

     



     

    }
}
