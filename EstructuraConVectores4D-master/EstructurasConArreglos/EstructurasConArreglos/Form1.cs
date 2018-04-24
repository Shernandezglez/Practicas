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
        Inventario inv = new Inventario(5);
        Producto pro;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto pro = new Producto(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(txtCant.Text), Convert.ToInt32(txtCst.Text),txtName.Text,txtDesc.Text);
            inv.agregarProducto(pro);
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtCat.Text = inv.buscar(Convert.ToInt32(txtDatos.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inv.eliminarProducto(Convert.ToInt32(txtDatos.Text));
        }
    }
}
