using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectors
{
    public partial class Form1 : Form
    {
        MiVector vector;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearVector_Click(object sender, EventArgs e)
        {
            int tv = Convert.ToInt32(txtTamanioVector.Text);
            vector = new MiVector(tv);

            

        }

        private void btnLlenarVector_Click(object sender, EventArgs e)
        {
            vector.llenar();
            
        }
        private void btnLlenarAleatorio_Click(object sender, EventArgs e)
        {
            int tv = Convert.ToInt32(txtTamanioVector.Text);
            vector.llenarAlwatorio(tv);
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            vector.mostrar();
            txtInfo.Text += vector.mostrar().ToString() + Environment.NewLine;
        }

        private void btnMostrarInverso_Click(object sender, EventArgs e)
        {
            vector.mostrarInverso();
            txtInfo.Text += vector.mostrarInverso().ToString() + Environment.NewLine;
        }

        private void btnSumarVector_Click(object sender, EventArgs e)
        {
            txtSuma.Clear();
            vector.sumar();
            txtSuma.Text += vector.sumar().ToString();
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            
            txtPromedio.Clear();
            vector.promediar();
            txtPromedio.Text += vector.promediar().ToString();
        }

        private void btnGirarArriba_Click(object sender, EventArgs e)
        {
            vector.girar();
            txtInfo.Text += vector.girar().ToString() + Environment.NewLine;
        }
    }
}
