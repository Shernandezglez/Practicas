using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    abstract class Guerrero:ServVivo
    {
        protected string _nombre;
        protected int _blanco;
        private static Random aleat = new Random();

        public string Nombre { get { return _nombre; } }



        public Guerrero(string nombre)
        {
            _nombre = nombre;
            _blanco = aleat.Next(10);
        }

        public int disparar()
        {
            if (_estaVivo)
                return aleat.Next(10);
            else
                return -1;

        }

        public override string ToString()
        {
            return _nombre + base.ToString();
        }
    }
}
