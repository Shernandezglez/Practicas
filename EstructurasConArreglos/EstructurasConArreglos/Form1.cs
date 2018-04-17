using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasConArreglos
{
    public partial class Form1 : Form
    {
        Inventario inv = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inv.agregarProducto(txtCodigo.Text, txtName.Text,txtDesc.Text,txtCant.Text,txtCst.Text);
            txtCodigo.Clear();
            txtName.Clear();
            txtDesc.Clear();
            txtCant.Clear();
            txtCst.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCat.Text = inv.listarProductos();

        }
    }
}
