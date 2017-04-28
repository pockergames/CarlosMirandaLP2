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
            int carros, i = 0;
            Console.WriteLine("Informe o a quantidade de carros a serem analisados");
            carros = Convert.ToInt32(Console.ReadLine());
            string[] modelo = new string[carros];
            double[] km = new double[carros];
            double[] pot = new double[carros];
            string[] classKm = new string[carros];
            string[] classPot = new string[carros];
            while (i < carros)
            {
                Console.WriteLine("Informe o modelo do carro {0}", i + 1);
                modelo[i] = Console.ReadLine();
                Console.WriteLine("Informe a quilometragem do carro {0}", i + 1);
                km[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a potência do carro {0}", i + 1);
                pot[i] = Convert.ToDouble(Console.ReadLine());
            
                if (km[i] <= 5000)
                {
                    classKm[i] = "Novo";
                }
                else if (km[i] > 5000 && km[i] <= 30000)
                {
                    classKm[i] = "Semi-novo";
                }
                else if (km[i] > 30000)
                {
                    classKm[i] = "Velho";
                }
                if (pot[i] < 120)
                {
                    classPot[i] = "Popular";
                }
                else if (pot[i] >= 120 && pot[i] <= 200)
                {
                    classPot[i] = "Forte";
                }
                else if (pot[i] > 200)
                {
                    classPot[i] = "Potente";
                }
                Console.WriteLine("{0} - {1} - {2}", modelo[i], classKm[i], classPot[i]);
                i++;
            }
            



        }
            


        }
    }

