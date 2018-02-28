using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    class Calcular
    {
        private int _procesoActual;
        private double _tET;
        private double _tFT;
        private double _tiempoDeProceso;
        private int _procesos;
        
        

        public Calcular(int totalDeProcesos, double tiempoPromedio)
        {
            _procesoActual = 1;
            _tiempoDeProceso = tiempoPromedio;
            _procesos = totalDeProcesos;
            _tET = 0;
            _tFT = 0;
        }

        public void procesoFCFS()
        {
            promedioDeFinalizacion();
            promedioDeEspera();
                 
            
        }


        //Calcula los tiempos promedio de espera y finalizacion de cada proceso
        private double promedioDeEspera()
        {
            double t1 = 0;
            for (int i = _procesoActual; i <= _procesos; i++)
            {
                t1 += _tiempoDeProceso;
                _tET += t1;
            }

            return _tET;

        }

        private double promedioDeFinalizacion()
        {
            double t2 = _tiempoDeProceso;

            for (int i = _procesoActual; i <= _procesos; i++)
            {

                t2 += _tiempoDeProceso;
                _tFT += t2;

            }
            return _tFT;
        }

        public int getProcesoActual
        {
            get { return _procesoActual; }
        }



    }
}
