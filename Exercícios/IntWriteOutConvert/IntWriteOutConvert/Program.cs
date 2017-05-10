using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntWriteOutConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = IntWriteOutConvert(Console.ReadLine());
            int y = IntWriteOutConvert(Console.ReadLine());

            Console.WriteLine(x + y);
        }
        public static int IntWriteOutConvert(string number)
        {
            int dezena = 0;
            int unidade = 0;
            int centena = 0;

            if (number == "zero")
                unidade = 0;
            else if (number.EndsWith("um"))
                unidade = 1;
            else if (number.EndsWith("dois"))
                unidade = 2;
            else if (number.EndsWith("três"))
                unidade = 3;
            else if (number.EndsWith("quatro"))
                unidade = 4;
            else if (number.EndsWith("cinco"))
                unidade = 5;
            else if (number.EndsWith("seis") && !number.StartsWith("dez"))
                unidade = 6;
            else if (number.EndsWith("sete") && !number.StartsWith("dez"))
                unidade = 7;
            else if (number.EndsWith("oito") && !number.StartsWith("dez"))
                unidade = 8;
            else if (number.EndsWith("nove") && !number.StartsWith("dez"))
                unidade = 9;


            if (number.EndsWith("dez"))
            {
                unidade = 0;
                dezena = 10;
            }
            else if (number.EndsWith("onze"))
            {
                unidade = 1;
                dezena = 10;
            }
            else if (number.EndsWith("doze"))
            {
                unidade = 2;
                dezena = 10;
            }
            else if (number.EndsWith("treze"))
            {
                unidade = 3;
                dezena = 10;
            }
            else if (number.EndsWith("quatorze") || number.EndsWith("catorze"))
            {
                unidade = 4;
                dezena = 10;
            }
            else if (number.EndsWith("quinze"))
            {
                unidade = 5;
                dezena = 10;
            }
            else if (number.EndsWith("dezesseis"))
            {
                dezena = 16;
            }
            else if (number.EndsWith("dezessete"))
            {
                dezena = 17;
            }
            else if (number.EndsWith("dezoito"))
            {
                dezena = 18;
            }
            else if (number.EndsWith("dezenove"))
            {
                dezena = 19;
            }


            for (int i = 0; i < number.Length - 4; i++)
            {
                if (number[i] == 'v' && number[i + 1] == 'i' && number[i + 2] == 'n' && number[i + 3] == 't' && number[i + 4] == 'e')
                    dezena = 20;
                else if (number[i] == 't' && number[i + 1] == 'r' && number[i + 2] == 'i' && number[i + 3] == 'n' && number[i + 4] == 't')
                    dezena = 30;
                else if (number[i] == 'q' && number[i + 1] == 'u' && number[i + 2] == 'a' && number[i + 3] == 'r' && number[i + 4] == 'e')
                    dezena = 40;
                else if (number[i] == 'c' && number[i + 1] == 'i' && number[i + 2] == 'n' && number[i + 3] == 'q' && number[i + 4] == 'u')
                    dezena = 50;
                else if (number[i] == 's' && number[i + 1] == 'e' && number[i + 2] == 's' && number[i + 3] == 's' && number[i + 4] == 'e')
                    dezena = 60;
                else if (number[i] == 's' && number[i + 1] == 'e' && number[i + 2] == 't' && number[i + 3] == 'e' && number[i + 4] == 'n')
                    dezena = 70;
                else if (number[i] == 'o' && number[i + 1] == 'i' && number[i + 2] == 't' && number[i + 3] == 'e' && number[i + 4] == 'n')
                    dezena = 80;
                else if (number[i] == 'n' && number[i + 1] == 'o' && number[i + 2] == 'v' && number[i + 3] == 'e' && number[i + 4] == 'n')
                    dezena = 90;
            }
            if (number.StartsWith("cento") || number == "cem")
            {
                centena = 100;
            }
            else if (number.StartsWith("duzentos"))
            {
                centena = 200;
            }
            else if (number.StartsWith("trezentos"))
            {
                centena = 300;
            }
            else if (number.StartsWith("quatrocentos"))
            {
                centena = 400;
            }
            else if (number.StartsWith("quinhentos"))
            {
                centena = 500;
            }
            else if (number.StartsWith("seiscentos"))
            {
                centena = 600;
            }
            else if (number.StartsWith("setecentos"))
            {
                centena = 700;
            }
            else if (number.StartsWith("oitocentos"))
            {
                centena = 800;
            }
            else if (number.StartsWith("novecentos"))
            {
                centena = 900;
            }
            return (centena + dezena + unidade);
        }
    }
}
