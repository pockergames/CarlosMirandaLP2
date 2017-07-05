using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Questao
    {
        public int a;
        public int b;
        public int c;
        public int d;
        public int e;
        int acertou = 0;
        int amb = 0;
        char certa;

        public char Certa()
        {
            

            if (a > 100 && a < 155)
            {
                amb++;
            }
            else if (b > 100 && b < 155)
            {
                amb++;
            }
            else if (c > 100 && c < 155)
            {
                amb++;
            }
            else if (d> 100 && d < 155)
            {
                amb++;
            }
            else if (e > 100 && e < 155)
            {
                amb++;
            }
            

            if (amb == 0)
            {
                if (a <= 100)
                {
                    acertou++;
                    certa = 'A';
                }
                else if (b <= 100)
                {
                    acertou++;
                    certa = 'B';
                }
                else if (c <= 100)
                {
                    acertou++;
                    certa = 'C';
                }
                else if (d <= 100)
                {
                    acertou++;
                    certa = 'D';
                }
                else if (e <= 100)
                {
                    acertou++;
                    certa = 'E';
                }
                    return certa;
            }
            else
            {
                return '*';
            }

            


        }

    }
}
