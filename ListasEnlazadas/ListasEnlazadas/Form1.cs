using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Estructura catalogo = new Estructura();

        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            
            ClaseBase nuevo;
            nuevo = new ClaseBase(Convert.ToInt32(textBox1.Text));
            catalogo.agregar(nuevo);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            textBox2.Text = catalogo.listar();
        }
    }
}
