using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasConArreglos
{
    class Producto
    {
        public int codigo;
        private int _cantidad;
        private int _costo;

        private string _nombre;
        private string _desc;

        public Producto(int cd,int cnt,int cst, string nm, string desc)
        {
            codigo = cd;
            _cantidad = cnt;
            _costo = cst;
            _nombre = nm;
            _desc = desc;
        }


        public override string ToString()
        {
            System.Reflection.PropertyInfo[] props =
                      this.GetType().GetProperties();
            string[] strs = new string[props.Length];
            for (int i = 0; i < props.Length; i++)
                strs[i] = props[i].Name + "[" + props[i].GetValue(this, null) + "]";

            return string.Join(", ", strs);
        }

        public int code { get { return codigo; } }
        public int cantidad { get { return _cantidad; } }
        public int costo { get { return _costo; } }
        public string nombre { get { return _nombre; } }
        public string desc { get { return _desc;} }

    }
}
