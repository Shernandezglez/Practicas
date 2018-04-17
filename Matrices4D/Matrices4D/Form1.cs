using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices4D
{
    public partial class Form1 : Form
    {
        Matriz mt = new Matriz();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            txtResultados.Text = mt.mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtResultados.Text = mt.mostrarDPC();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultados.Text = mt.mostrarDSC();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            txtResultados.Text = mt.mostrarArribaDPC();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            txtResultados.Text = mt.mostrarAbajoDPC();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mt.llenar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mt.invertirTriengulos();
        }
    }
}
