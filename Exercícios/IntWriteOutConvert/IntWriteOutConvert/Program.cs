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
            Console.WriteLine(x);
        }
        public static int IntWriteOutConvert(string number)
        {
            int dezena = 0;
            int unidade = 0;
            int centena = 0;

            if (number == "zero")
                unidade = 0;
            else if (number.EndsWith("um") == true)
                unidade = 1;
            else if (number.EndsWith("dois") == true)
                unidade = 2;
            else if (number.EndsWith("três") == true)
                unidade = 3;
            else if (number.EndsWith("quatro") == true)
                unidade = 4;
            else if (number.EndsWith("cinco") == true)
                unidade = 5;
            else if (number.EndsWith("seis") == true && number.StartsWith("dez") == false)
                unidade = 6;
            else if (number.EndsWith("sete") == true && number.StartsWith("dez") == false)
                unidade = 7;
            else if (number.EndsWith("oito") == true && number.StartsWith("dez") == false)
                unidade = 8;
            else if (number.EndsWith("nove") == true && number.StartsWith("dez") == false)
                unidade = 9;


            if (number.EndsWith("dez") == true)
            {
                unidade = 0;
                dezena = 10;
            }
            else if (number.EndsWith("onze") == true)
            {
                unidade = 1;
                dezena = 10;
            }
            else if (number.EndsWith("doze") == true)
            {
                unidade = 2;
                dezena = 10;
            }
            else if (number.EndsWith("treze") == true)
            {
                unidade = 3;
                dezena = 10;
            }
            else if (number.EndsWith("quatorze") == true || number.EndsWith("catorze") == true)
            {
                unidade = 4;
                dezena = 10;
            }
            else if (number.EndsWith("quinze") == true)
            {
                unidade = 5;
                dezena = 10;
            }
            else if (number.EndsWith("dezesseis") == true)
            {
                return 16;
            }
            else if (number.EndsWith("dezessete") == true)
            {
                return 17;
            }
            else if (number.EndsWith("dezoito") == true)
            {
                return 18;
            }
            else if (number.EndsWith("dezenove") == true)
            {
                return 19;
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
            if (number.StartsWith("cento"))
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
