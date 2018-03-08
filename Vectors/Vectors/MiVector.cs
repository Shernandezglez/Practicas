﻿using System;
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
            for(int i = 0; i < _v.Length; i++)
            {
                _v[i] = i + 1;
            }

            return _v.Length;
        }

        public int llenarAlwatorio(int limite)
        {
            limite = _v.Length;
            

            for( int i = 0; i < limite; i++)
            {
                _v[i] += rnd.Next(limite);
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

        public int sumar()
        {
            int sum = 0;
            for (int i = 0; i < _v.Length; i++)
            {
                sum = _v.Sum();
            }
            return sum;
        }

        public double promediar()
        {
            double prom = 0.0;
            for(int i = 0; i < _v.Length; i++)
            {
                prom = _v.Sum() / _v.Length;
            }
            return prom;

        }

        public string girar()
        {
            string cosa = "";
            int min = _v.Min();
            int max = _v.Max();
            for(int i = 0; i < _v.Length; i++)
            {
                max = min;
                

                cosa += "[" + i + "]=" + _v[i].ToString()  + Environment.NewLine;
            }
            return cosa;

        }


     
    }
}
