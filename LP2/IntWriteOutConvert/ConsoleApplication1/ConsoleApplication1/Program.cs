using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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

            if (number.EndsWith("um") == true)
                unidade = 1;
            else if (number.EndsWith("dois") == true)
                unidade = 2;
            else if (number.EndsWith("três") == true)
                unidade = 3;
            else if (number.EndsWith("quatro") == true)
                unidade = 4;
            else if (number.EndsWith("cinco") == true)
                unidade = 5;
            else if (number.EndsWith("seis") && number.StartsWith("dez") == false)
                unidade = 6;
            else if (number.EndsWith("sete") == true && number.StartsWith("dez") == false)
                unidade = 7;
            else if (number.EndsWith("oito") == true && number.StartsWith("dez") == false)
                unidade = 8;
            else if (number.EndsWith("nove") == true && number.StartsWith("dez") == false)
                unidade = 9;
            else if (number == "onze")
            {
                unidade = 1;
                dezena = 10;
            }
            else if (number == "doze")
            {
                unidade = 2;
                dezena = 10;
            }
            else if (number == "treze")
            {
                unidade = 3;
                dezena = 10;
            }
            else if (number == "quatorze" || number == "catorze")
            {
                unidade = 4;
                dezena = 10;
            }
            else if (number == "quinze")
            {
                unidade = 5;
                dezena = 10;
            }
            else if (number == "dezesseis")
            {
                return 16;
            }
            else if (number == "dezessete")
            {
                return 17;
            }
            else if (number == "dezoito")
            {
                return 18;
            }
            else if (number == "dezenove")
            {
                return 19;
            }


            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 'v' && number[i + 1] == 'i' && number[i + 2] == 'n' && number[i + 3] == 't' && number[i + 4] == 'e')
                {
                    dezena = 20;
                }
                else if (number[i] == 't' && number[i + 1] == 'r' && number[i + 2] == 'i' && number[i + 3] == 'n' && number[i + 4] == 't')
                {
                    dezena = 30;
                }
                else if (number[i] == 'q' && number[i + 1] == 'u' && number[i + 2] == 'a' && number[i + 3] == 'r' && number[i + 4] == 'e')
                {
                    dezena = 40;
                }
                else if (number[i] == 'c' && number[i + 1] == 'i' && number[i + 2] == 'n' && number[i + 3] == 'q' && number[i + 4] == 'u')
                {
                    dezena = 50;
                }
                

            }

            return (dezena + unidade);
        }
    }
}
