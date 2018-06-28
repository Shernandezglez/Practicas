using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        Estructura fifo = new Estructura();
        

        private void button1_Click(object sender, EventArgs e)
        {

            ClaseCaracteres exp = new ClaseCaracteres(Convert.ToChar(txtExp.Text));
            ClaseNumeros num = new ClaseNumeros(exp.Expresion);
            fifo.encolarFifo(exp);
            if(exp.Expresion == num.Numero)
            {
                fifo.encolarLifo(num);
            }
            else
            {

            }

            if(fifo.inicio == null)
            {
                txtExp.Text = fifo.verLifo().ToString();
                if (fifo.start == null)
                {
                    txtExp.Text = "vacio";
                }
            }

        }
    }
}
