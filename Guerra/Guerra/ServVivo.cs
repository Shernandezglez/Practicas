using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    abstract class ServVivo
    {
        protected bool _estaVivo;

        public bool EstavVivo { get { return _estaVivo; } }

        public ServVivo()
        {
            _estaVivo = true;
        }

        public override string ToString()
        {
            string estado = "muerto";
            if (_estaVivo)
                estado = " vivo ";
            return estado;
        }
    }
}
