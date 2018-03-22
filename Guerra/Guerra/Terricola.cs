using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    class Terricola:Guerrero
    {
        private static int _totalVivos = 0;

        public int TotalVivos { get { return _totalVivos; } }

        public Terricola(string nombre)
            :base(nombre)
        {
            _totalVivos++;
        }

        public void recibirDisparo(int disparo)
        {
            if(_estaVivo && _blanco == disparo)
            {
                _estaVivo = false;
                _totalVivos--;
            }
           
        }

        public override string ToString()
        {
            string estadoGuerrero = _nombre + " Esta muerto";
            return estadoGuerrero;
        }


    }
}
