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
            txtInfo.Text = vector.mostrar().ToString();
        }

        private void btnMostrarInverso_Click(object sender, EventArgs e)
        {
            
            txtInfo.Text = vector.mostrarInverso().ToString();
        }

        private void btnSumarVector_Click(object sender, EventArgs e)
        {
            txtSuma.Clear();
            txtSuma.Text += vector.sumar().ToString();
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            
            txtPromedio.Clear();
            txtPromedio.Text += vector.promediar().ToString();
        }

        private void btnGirarArriba_Click(object sender, EventArgs e)
        {
            vector.girarArriba();
           
        }

        private void btnGirarAbajo_Click(object sender, EventArgs e)
        {
            vector.girarAbajo();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            vector.invertirVector();
        }
    }
}
