using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanzamientoDeDado
{
    public partial class Form1 : Form
    {
        Dado d = new Dado();
        public int[] c;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLanzarUnaVez_Click(object sender, EventArgs e)
        {
            txtResultados.Text += d.lanzamiento().ToString() + Environment.NewLine;
        }

        //dado    1 2 3 4 5 6   r
        //p vec   0 1 2 3 4 5   r-1
        //
        private void btnCienLanzamientos_Click(object sender, EventArgs e)
        {
            txtResultados.Clear();
            c = new int[6];
            int r = 0;

            for (int i = 0; i <=100; i++)
            {
                r = d.lanzamiento();
                if (r <= 6)
                {
                    c[r - 1] += 1;
                }
            /*
                if (r == 1)
                {
                    c[0] += 1;
                }
                else if(r == 2)
                {
                    c[1] += 1;
                }
                else if(r == 3)
                {
                    c[2] += 1;
                }
                else if (r == 4)
                {
                    c[3] += 1;
                }
                else if (r == 5)
                {
                    c[4] += 1;
                }
                else if (r == 6)
                {
                    c[5] += 1;
                }
                */
            }

            for(int j = 0; j < c.Length; j++)
            {
                
                txtResultados.Text += "[ " + (j+1)  + " ]" + c[j].ToString() + Environment.NewLine;
            }

        }
    }
}
