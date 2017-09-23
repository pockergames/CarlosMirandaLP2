using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMorse
{
    class Mensagem
    {
        private string[] morse = new string[] { " .- ", " -... ", " -.-. "," -.. "," . "," ..-. "," --. "," .... "," .. ",
            " .--- "," -.- ", " .-.. ", " -- ", " -. ", " --- ", " .--. ", " --.- ",
            " .-. ", " ... ", " - ", " ..- ", " ...- ", " .-- ", " -..- ", " -.-- ", " --.. ", "  "};

        private char[] alfab = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P' ,'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '};

        public string Codificar(string txt)
        {
            string resposta = "";                                               
            for (int i = 0; i < txt.Length; i++)
            {
                for(int j = 0; j < alfab.Length; j++)
                {
                    if(txt[i] == alfab[j])
                    {
                        resposta += morse[j];
                    }
                }
            }
            return resposta;
        }

        public string Decodificar(string txt)
        {
            /*string[] codMorse = txt.Split(' ');

            string resposta = "";
            for (int i = 0; i < codMorse.Length; i++)
            {
                for (int j = 0; j < morse.Length; j++)
                {
                    if (codMorse[i] == morse[j])
                    {
                        resposta += alfab[j];
                    }
                }
            }
            return resposta;*/


            string[] codMorse = txt.Split(' ');
            string resposta = "";
            
            for (int i = 1; i <= codMorse.Length; i++)
            {
                for (int j = 0; j < morse.Length; j++)
                {
                    if (codMorse[i] == morse[j])
                    {
                        resposta += alfab[j];
                    }
                }
            }
            return resposta;

        }




    }
}
