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
            int carros, j = 0;
            Console.WriteLine("Informe o a quantidade de carros a serem analisados");
            carros = Convert.ToInt32(Console.ReadLine());
            string[] modelo = new string[carros];
            double[] km = new double[carros];
            double[] pot = new double[carros];

            while (j < carros)
            {
                Console.WriteLine("Informe o modelo do carro {0}", j + 1);
                modelo[j] = Console.ReadLine();
                Console.WriteLine("Informe a quilometragem do carro {0}", j + 1);
                km[j] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a potência do carro {0}", j + 1);
                pot[j] = Convert.ToDouble(Console.ReadLine());
                j++;
            }

            
            for (int i = 0; i < carros; i++)
            {
                Console.WriteLine(Classificar(modelo[i], km[i], pot[i]));
            }
            
        }
        static string Classificar(string modelo, double km, double pot)
        {
            string classKm, classPot;
            if (km <= 5000)
            {
                classKm = "Novo";
            }
            else if (km > 5000 && km <= 30000)
            {
                classKm = "Semi-novo";
            }
            else
            {
                classKm = "Velho";
            }
            if (pot < 120)
            {
                classPot = "Popular";
            }
            else if (pot >= 120 && pot <= 200)
            {
                classPot = "Forte";
            }
            else
            {
                classPot = "Potente";
            }
            string resp = modelo + " - " + classKm + " - " + classPot;
            return resp;
        }




    }
}

