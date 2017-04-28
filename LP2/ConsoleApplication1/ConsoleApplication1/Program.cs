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
            carro = Console.ReadLine();
            int[] modelo = new int[carro-1];
            double[] km = new double[carro - 1];
            double[] pot = new double[carro - 1];
            while(i < carros - 1)
            {
                Console.WriteLine("Informe o modelo do carro {0}", i);
                modelo[i] = Console.ReadLine();
                Console.WriteLine("Informe a quilometragem do carro {0}", i);
                km[i] = Console.ReadLine();
                Console.WriteLine("Informe a potência do carro {0}", i);
                pot[i] = Console.ReadLine();

            }



        }
            


        }
    }

