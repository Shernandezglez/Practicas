using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasConArreglos
{
    class Inventario
    {
        private string[] _inv;
        private string _data;


        public Inventario()
        {
            _inv = new string[15];
            _data = getProductos;
        }

        public void agregarProducto(string cod, string nom, string desc, string cant, string cst)
        {
            

            for(int i = 0; i < _inv.Length; i++)
            {
                _inv[i] += " | " + cod + " | " + nom + " | " +desc + " | " + cant + " | " + cst + " | " + Environment.NewLine;
            }
            
        }


        public string listarProductos()
        {

            
            for(int i = 0; i < 1; i++)
            {
                _data += _inv[i].ToString() ;
            }


            
            return _data;
        }

        public string getProductos
        {
            get { return _data; }
        }

    }
}
