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

        FIFO fifo = new FIFO();
        LIFO lifo = new LIFO();


        private void button1_Click(object sender, EventArgs e)
        {
            FIFO fifo = new FIFO();
            LIFO lifo = new LIFO();

            ClaseCaracteres exp;
            ClaseNumeros num;

            string cdn = txtExp.Text;
            

            foreach (var car in cdn.ToArray())
            {
                exp = new ClaseCaracteres(car);

                fifo.encolarFifo(exp);

                if (exp.Expresion == '1' || exp.Expresion == '2' || exp.Expresion == '3' ||
                    exp.Expresion == '4' || exp.Expresion == '5' || exp.Expresion == '6' ||
                    exp.Expresion == '7' || exp.Expresion == '8' || exp.Expresion == '9')
                {
                    num = new ClaseNumeros(exp.Expresion);
                    lifo.encolarLifo(num);
                }

                
            }
            
            while(fifo.peek().Expresion != null)
            {
                if (fifo.peek().Expresion == '1' || fifo.peek().Expresion == '2' ||
               fifo.peek().Expresion == '3' || fifo.peek().Expresion == '4' ||
               fifo.peek().Expresion == '5' || fifo.peek().Expresion == '6' ||
               fifo.peek().Expresion == '7' || fifo.peek().Expresion == '8' ||
               fifo.peek().Expresion == '9')
                {
                    fifo.pop();
                }
                else
                {
                    break;
                }
            }

            
            

            if (fifo.peek().Expresion == 's' && lifo.start != null && lifo.start.Siguiente != null)
            {

                int s = 0;

                s = lifo.start.Numero + lifo.start.Siguiente.Numero;


                num = new ClaseNumeros(s);

                lifo.encolarLifo(num);

                while(lifo.verLifo().Siguiente != null)
                {
                    if(lifo.verLifo().Siguiente.Numero == lifo.start.Numero || lifo.verLifo().Siguiente.Numero == lifo.start.Siguiente.Numero)
                    {
                        lifo.pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }

            txtResultado.Text = lifo.verLifo().ToString();
        }
    }
}
