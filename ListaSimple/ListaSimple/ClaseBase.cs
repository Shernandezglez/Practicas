using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    class ClaseBase
    {
        private string _producto;
        private string _alumno;
        private int _contacto;
        private string _vehiculo;

        private ClaseBase _siguiente;

        public ClaseBase(string pro, string al, int cont, string ve)
        {
            _producto = pro;
            _alumno = al;
            _contacto = cont;
            _contacto = cont;
            _vehiculo = ve;
        }

        public string Producto { get; set; }

        public string Alumno { get; set; }

        public int Contacto { get; set; }

        public string Vehiculo { get; set; }

        public ClaseBase Siguiente { get; set; }

        public override string ToString()
        {
            return "Producto: " + _producto + " | " + "Alumno: " + _alumno + 
                " | " + "Contacto: " + _contacto + " | " + " Vehiculo: " + _vehiculo;
        }
    }
}
