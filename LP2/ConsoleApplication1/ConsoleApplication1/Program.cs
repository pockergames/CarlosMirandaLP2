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
            Console.WriteLine("Informe o n° de carros");
            carros = Convert.ToInt32(Console.ReadLine());
            string[] modelo = new string[carros];
            double[] km = new double[carros];
            double[] pot = new double[carros];
            string[] classKm = new string[carros];
            string[] classPot = new string[carros];

            while(i < carros)
            {
                Console.WriteLine("Informe o modelo do carro {0}", i + 1);
                modelo[i] = Console.ReadLine();
                Console.WriteLine("Informe a quilometragem do carro {0}", i + 1 );
                km[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a potência do carro {0}", i + 1);
                pot[i] = Convert.ToDouble(Console.ReadLine());
                i++;
            }
            
            while(i < carros)
            {
                if (km[i] <= 5000) 
                {
                    classKm[i] = "novo";
                }
                    else if (km[i] > 5000 || km[i] <= 30000)
                {
                    classKm[i] = "semi-novo";
                }
                    else if (km[i] <= 30000)
                {
                    classKm[i] = "velho";
                }
                if (pot[i] > 200)
                {
                    classPot[i] = "forte";
                }
                else if (km[i] >= 120 || km[i] <= 200)
                {
                    classPot[i] = "mediano";
                }
                else
                {
                    classPot[i] = "popular";
                }
                i++;

                Console.WriteLine("{0} - {1} - {3}", modelo[i], classKm, classPot);
                
            }
                

            }
            


        }
    }

