using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class MiVector
    {
        private int[] _v;
        Random rnd = new Random();
        

        public MiVector(int tamanio)
        {
            _v = new int[tamanio];

        }

        public int llenar()
        {
            for(int i = 0; i < _v.Length  ; i++)
            {
                _v[i] += i;
            }

            return _v.Length;
        }

        public int llenarAlwatorio(int limite)
        {
            limite += _v.Length;
            

            for( int i = 0; i < limite; i++)
            {
                _v[i] += rnd.Next(_v.Length);
            }

            return _v.Length;
        }

        public string mostrar()
        {
            string cosa = "";
            for (int i = 0; i < _v.Length; i++)
            {
                 cosa += "[" + i + "]=" + _v[i].ToString() + Environment.NewLine;
            }

            return cosa;
        }

        public string mostrarInverso()
        {
            string cosa = "";
            for (int i = _v.Length-1; i >= 0; i--)
            {
               cosa += "[" + i + "]=" + _v[i].ToString() + Environment.NewLine;
            }

            return cosa;
        }

        public void sumar()
        {
            for (int i = 0; i < _v.Length; i++)
            {
                _v[i] = _v.Sum();
            }
        }

        public void promediar()
        {
            for(int i = 0; i < _v.Length; i++)
            {
                
            }
        }


     
    }
}
