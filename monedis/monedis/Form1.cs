using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monedis
{
    public partial class Form1 : Form
    {
        LanzamientoDeMoneda l = new LanzamientoDeMoneda();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUn_Click(object sender, EventArgs e)
        {
            txtRes.Clear();
            l.lanzamientoMoneda();

            if (l.getResultado == 1)
            {
                txtRes.Text += "AGUILA" + Environment.NewLine;
            }
            else
            {
                txtRes.Text += "SELLO" + Environment.NewLine;
            }
        }

        private void btnDiez_Click(object sender, EventArgs e)
        {
            txtRes.Clear();


            for(int i = 0; i <=10; i++)
            {

                l.lanzamientoMoneda();

                if (l.getResultado == 1)
                {
                    txtRes.Text += "AGUILA" + Environment.NewLine;
                }
                else
                {
                    txtRes.Text += "SELLO" + Environment.NewLine;
                }
            }
        }
    }
}
