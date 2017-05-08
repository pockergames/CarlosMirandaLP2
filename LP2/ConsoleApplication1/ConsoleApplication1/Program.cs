using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct CARRO
        {
            public string modelo;
            public double km;
            public double pot;
        }

        static void Main(string[] args)
        {
            int carros, j = 0;
            Console.WriteLine("Informe o a quantidade de carros a serem analisados");
            carros = Convert.ToInt32(Console.ReadLine());
            CARRO[] carroModel = new CARRO[carros];

            while (j < carros)
            {
                Console.WriteLine("Informe o modelo do carro {0}", j + 1);
                carroModel[j].modelo = Console.ReadLine();
                Console.WriteLine("Informe a quilometragem do carro {0}", j + 1);
                carroModel[j].km = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a potência do carro {0}", j + 1);
                carroModel[j].pot = Convert.ToDouble(Console.ReadLine());
                j++;
            }

            
            for (int i = 0; i < carros; i++)
            {
                Console.WriteLine(Classificar(carroModel[i]));
            }
            
        }
        public static string Classificar(CARRO carro)
        {
            string classKm, classPot;
            if (carro.km <= 5000)
            {
                classKm = "Novo";
            }
            else if (carro.km > 5000 && carro.km <= 30000)
            {
                classKm = "Semi-novo";
            }
            else
            {
                classKm = "Velho";
            }
            if (carro.pot < 120)
            {
                classPot = "Popular";
            }
            else if (carro.pot >= 120 && carro.pot <= 200)
            {
                classPot = "Forte";
            }
            else
            {
                classPot = "Potente";
            }
            string resp = carro.modelo + " - " + classKm + " - " + classPot;
            return resp;
        }




    }
}

