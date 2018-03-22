using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guerra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nave nave = new Nave("Terricola");

            Nave navem = new Nave("Marciano");

            while (nave.cuantosQuedan() > 0 && navem.cuantosQuedan() > 0)
            {
                for (int turno = 0; turno < 10; turno++)
                {
                    navem.recibirDisparo(nave.disparar(turno));
                    nave.recibirDisparo(navem.disparar(turno));
                }
            }

            if (nave.cuantosQuedan() > 0)
                MessageBox.Show("Ganan los terricolas");
            else
                MessageBox.Show("Ganan los marciano");

        }
    }
}
