using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Corredor
    {
        Random rnd = new Random();
        private int _pista;
        private int _corredor1;
        private int _corredor2;

        public Corredor(int limiteDeLaPista)
        {
            _pista = limiteDeLaPista;
            _corredor1 = correr();
            _corredor2 = correr();
        }

        public int correr()
        {
            int pasos = 0;
            pasos = rnd.Next(1, 7);
            for (int i = 0; i < 10; i++)
            {
                if (pasos % 6 == 2)
                {
                    pasos = 2;
                }
                else if (pasos % 6 == 1)
                {
                    pasos = 1;
                }
                else if (pasos % 6 == 3)
                {
                    pasos = 3;
                }
                else
                {
                    pasos = 0;
                }
            }
            return pasos;
        }

        public int getPosicionCorredor1
        {
            get { return _corredor1; }
        }
        public int getPosicionCorredor2
        {
            get { return _corredor2; }
        }


    }
}
