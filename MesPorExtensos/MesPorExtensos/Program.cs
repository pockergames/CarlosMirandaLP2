using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesPorExtensos
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            string[] meses =  {"janeiro", "fevereiro", "março", "abril","maio","junho","julho","agosto","setembro","outubro","novembro","dezembro"};
            string data;
            Console.WriteLine("Informe a data");
            data = Console.ReadLine();
            dia = Convert.ToInt32(data.Substring(0, 2));
            mes = Convert.ToInt32(data.Substring(3, 2));
            ano = Convert.ToInt32(data.Substring(6, 4));
            Console.WriteLine("{0} de {1} de {2}", dia, meses[mes-1], ano);
            }

            }
        }
    

