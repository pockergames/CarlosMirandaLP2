using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    static class Menu
    {
        public static int Usuario { get; set; }

        public static void Principal()
        {
            
            Console.WriteLine("-------------------------Conversor de Medidas BETA 1.0--------------------------");
            Console.WriteLine("Desejo converter para:\n");
            Console.WriteLine("1 - Massa");
            Console.WriteLine("2 - Distância");
            Console.WriteLine("3 - Temperatura");
            Usuario = int.Parse(Console.ReadLine());

            if (Usuario == 1)
            {
                Console.WriteLine(Massa());
            }
                
            else if (Usuario == 2)
            {
                Console.WriteLine(Distancia());
                Distancia();
            }
                
            else if (Usuario == 3)
            {
                Console.WriteLine(Temperatura());
                Temperatura();
            }

        }
        public static string Massa()
        {
            Console.Clear();
            Console.WriteLine("-------------------------Conversor de Medidas BETA 1.0--------------------------");
            Console.WriteLine("Informe o número da unidade a qual deseja converter\n");
            Console.WriteLine("Escreva o valor a ser convertido seguido de sua unidade (sem vírgulas)\n");
            Console.WriteLine("1 - Kg (quilogramas)");
            Console.WriteLine("2 - g (gramas)");
            Console.WriteLine("3 - T (tonaladas)");
            Console.WriteLine("4 - Lbs (libras)");
            Console.WriteLine("0 - Voltar \n");
            Console.WriteLine("\nInforme o valor a ser convertido e em seguida sua unidade (não utilize espaços)\n");
            int usuario = int.Parse(Console.ReadLine());

            string resultado = "";

            if (usuario == 1)
            {
                resultado = Conversor.ParaKg(Console.ReadLine());
            }
            else if (usuario == 2)
            {
                resultado = Conversor.ParaG(Console.ReadLine());
            }
            else if (usuario == 3)
            {
                resultado = Conversor.ParaT(Console.ReadLine());
             
            }
            else if (usuario == 4)
            {
                resultado = Conversor.ParaLb(Console.ReadLine());
            }
            else if (usuario == 0)
            {
                Console.Clear();
                Principal();
            }
            return resultado;
        }
        public static string Distancia()
        {
            Console.Clear();
            Console.WriteLine("-------------------------Conversor de Medidas BETA 1.0--------------------------");
            Console.WriteLine("Informe o número da unidade a qual deseja converter\n");
            Console.WriteLine("Escreva o valor a ser convertido seguido de sua unidade (sem vírgulas)\n");
            Console.WriteLine("1 - m (metro)");
            Console.WriteLine("2 - Km (Quilogramas)");
            Console.WriteLine("3 - Milhas");
            Console.WriteLine("4 - Pés");
            Console.WriteLine("5 - Polegadas");
            Console.WriteLine("0 - Voltar \n");
            Console.WriteLine("\nInforme o valor a ser convertido e em seguida sua unidade (não utilize espaços)\n");
            int usuario = int.Parse(Console.ReadLine());
            string resultado = "";

            if (usuario == 1)
            {
                resultado = Conversor.ParaMetros(Console.ReadLine());
            }
            else if (usuario == 2)
            {
                resultado = Conversor.ParaKm(Console.ReadLine());
            }
            else if (usuario == 3)
            {
                resultado = Conversor.ParaMilhas(Console.ReadLine());

            }
            else if (usuario == 4)
            {
                resultado = Conversor.ParaPes(Console.ReadLine());
            }
            else if (usuario == 5)
            {
                resultado = Conversor.ParaPol(Console.ReadLine());
            }
            else if (usuario == 0)
            {
                Console.Clear();
                Principal();
            }
            return resultado;
        }
        public static string Temperatura()
        {
            int usuario;
            Console.Clear();
            Console.WriteLine("-------------------------Conversor de Medidas BETA 1.0--------------------------");
            Console.WriteLine("Informe o número da unidade a qual deseja converter\n");
            Console.WriteLine("Escreva o valor a ser convertido seguido de sua unidade (sem vírgulas)\n");
            Console.WriteLine("1 - °C (Celcius)");
            Console.WriteLine("2 - °F (Fahrenheit)");
            Console.WriteLine("3 - K (Kelvin)");
            Console.WriteLine("0 - Voltar \n");
            Console.WriteLine("\nInforme o valor a ser convertido e em seguida sua unidade (não utilize espaços)\n");

            usuario = int.Parse(Console.ReadLine());
            string resultado = "";

            if (usuario == 1)
                {
                    resultado = Conversor.ParaC(Console.ReadLine());
                }
                else if (usuario == 2)
                {
                    resultado = Conversor.ParaF(Console.ReadLine());
                }
                else if (usuario == 3)
                {
                    resultado = Conversor.ParaK(Console.ReadLine());
                }
                else if (usuario == 0)
                {
                    Console.Clear();
                    Principal();
                }
                return resultado;
        }



    }
}
