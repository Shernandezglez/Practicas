using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera
{
    public partial class Form1 : Form
    {
        Corredor c = new Corredor(100);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
             switch (c.getPosicionCorredor1)
                {
                    case 1:
                        txtResultados.Text += txtCorredorUno.Text.ToString() + " Está en: " + c.getPosicionCorredor1.ToString() + Environment.NewLine;
                        break;
                    case 2:
                        txtResultados.Text += txtCorredorUno.Text.ToString() + " Está en: " + c.getPosicionCorredor1.ToString() + Environment.NewLine;
                        break;
                    case 3:
                        txtResultados.Text += txtCorredorUno.Text.ToString() + " Está en: " + c.getPosicionCorredor1.ToString() + Environment.NewLine;
                        break;
                }   
             switch (c.getPosicionCorredor2)
                {
                    case 1:
                        txtResultados.Text += txtCorredorUno.Text.ToString() + " Está en: " + c.getPosicionCorredor2.ToString() + Environment.NewLine;
                        break;
                    case 2:
                        txtResultados.Text += txtCorredorUno.Text.ToString() + " Está en: " + c.getPosicionCorredor2.ToString() + Environment.NewLine;
                        break;
                    case 3:
                        txtResultados.Text += txtCorredorUno.Text.ToString() + " Está en: " + c.getPosicionCorredor2.ToString() + Environment.NewLine;
                        break;
                }   

            if (c.getPosicionCorredor1 > c.getPosicionCorredor2)
            {
                txtResultados.Text += txtCorredorUno.Text.ToString() + " Es el ganador" + Environment.NewLine;
            }
            else
            {
                txtResultados.Text += txtCorredorDos.Text.ToString() + " Es el ganador" + Environment.NewLine;

            }
        }
    }
}
