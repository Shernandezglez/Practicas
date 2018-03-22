using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    class Nave
    {
        Guerrero[] tropa = new Guerrero[10];
        private string _tipo;

        public Nave(string tipo)
        {
            _tipo = tipo;
            if(tipo == "Terricola")
            {
                for (int i = 0; i < 10; i++)
                    tropa[i] = new Terricola("T" + i);
            }
            else
                for(int i = 0; i < 10; i++)
                {
                    tropa[i] = new Marciano("M" + i);
                }

        }

        public int disparar(int tripulante)
        {
            return tropa[tripulante].disparar();
        }

        public void recibirDisparo(int disparo)
        {
            for(int i = 0; i <10; i++)
            {
                if(_tipo == "Terricola")
                {
                    Terricola t;

                    t = (Terricola)tropa[i];
                    t.recibirDisparo(disparo);
                }
                else
                {
                    Marciano m = (Marciano)tropa[i];
                    m.recibirDisparo(disparo);
                }
            }
        }

        public int cuantosQuedan()
        {
            if (_tipo == "Terricola")
            {
                return ((Terricola)tropa[1]).TotalVivos;
            }
            else
                return ((Marciano)tropa[4]).TotalVivos;
        }
    }
}
