using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EstructuraListaDoble cajas = new EstructuraListaDoble();
        FIFOcajas c = new FIFOcajas();
        ClaseBaseCaja activas;
        ClaseBasePersonas p;
        Random prob = new Random();

       

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            int cont = 1;

            while (activas != null)
            {
                cont++;

                activas = activas.Siguiente;

            }
            activas = new ClaseBaseCaja(cont);
            cajas.agregar(activas);

            for(int i = 1; i <= 300; i++)
            {
                int r = prob.Next(1, 101);

                if(r <= 40)
                {
                    if(activas.PersonasAtendiendo == 4)
                    {
                        activas = activas.Siguiente;

                    }
                    else
                    {
                        p = new ClaseBasePersonas();
                        c.push(p);
                    }

                    if (activas.Siguiente == null)
                    {
                        activas = new ClaseBaseCaja(1);
                        cajas.agregar(activas);
                    }
                    
                }
                if(c.peek()._ciclos > 0)
                {
                    c.peek()._ciclos--;

                    if(c.peek()._ciclos == 0)
                    {
                        c.pop();
                    }
                }

            }

        }
    }
}
