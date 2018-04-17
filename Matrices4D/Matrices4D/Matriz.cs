using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices4D
{
    class Matriz
    {
        private int[,] _mat = new int[6, 6];
        private int[,] _temp = new int[6, 6];

        public void llenar()
        {
            int n = 0;
            for (int c = 0; c < 6; c++)
            {
                for (int r = 0; r < 6; r++)
                {


                    _mat[c, r] = n++ + 1;
                    

                }

            }

            

        }
        public string mostrar()
        {
            string cosa = "";
            for (int c = 0; c < 6; c++)
            {
                for (int r = 0; r < 6; r++)
                {

                    cosa += _mat[c, r].ToString() + " | " + " ";
                }
                cosa += "\r\n";
            }


            return cosa;

        }

        public string mostrarArribaDPC()
        {
            string cdn = "";
            int nr = _mat.GetLength(0);
            int nc = _mat.GetLength(1);
            int n = 0;

            for (int r = 0; r < nr-1; r++)
            {
                for (int c = 1 + r; c < nc ; c++)
                {
                    cdn += _mat[r, c].ToString() + " | " + " ";
                }
                cdn += "\r\n";
            }

               
            return cdn;
        }

        public string mostrarAbajoDPC()
        {
            string cdn = "";
            int nr = _mat.GetLength(0);
            int nc = _mat.GetLength(1);
            int n = 0;

            for (int r = 1 + n; r < nr; r++)
            {
                n++;
                for (int c = 0; c <= n - 1; c++)
                {

                    cdn += _mat[r, c].ToString() + " | ";
                }

                cdn += "\r\n";
            }

            return cdn;
        }

        public string mostrarDPC()
        {
            string cdn = "";
            int nr = _mat.GetLength(0);
            int nc = _mat.GetLength(1);
          
           
           for(int r = 0; r < nr; r++)
           {
                
                for(int c = r; c <= 0 +r; c++)
                {
                    
                    cdn += _mat[r, c].ToString();
                    
                }
                cdn += "\r\n";
                
            }
            return cdn;
        }

        public string mostrarDSC()
        {
            string cdn = "";
            int nr = _mat.GetLength(0);
            int nc = _mat.GetLength(1);

            for(int r = 0; r < nr; r++)
            {
                for(int c = nc-r-1; c >= 5-r; c--)
                {
                    cdn += _mat[r, c].ToString() + " | ";
                }
                cdn += "\r\n";
            }
            return cdn;
        }

       public void invertirTriengulos()
        {
            int value = 0;
            for (int i = 1, t = 0; i < 6; i++, t++)
            {
                for (int j = 0; j <= t; j++)
                {
                    value = _mat[i, j];
                    _mat[i, j] = _mat[j, i];
                    _mat[j, i] = value;
                }
            }

        }

        

        
    }
}
