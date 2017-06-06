using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 600, a = 800;
            int[,] plano = new int[l, a];
            ConsoleKey comando;
            Objeto obj = new Objeto();
            Console.WriteLine("Posição inicial do Objeto");
            obj.x = int.Parse(Console.ReadLine());
            obj.y = int.Parse(Console.ReadLine());
            

            
                while (true)
                {
                    comando = Console.ReadKey().Key;

                    if (comando == ConsoleKey.RightArrow && obj.x <= l - 3 &&  obj.y <= a)
                        {
                            obj.AndarDireita();
                            Console.WriteLine(obj.Coordenadas());
                        }
                    else if(comando == ConsoleKey.LeftArrow && obj.x > 0 && obj.y <= a)
                        {
                            obj.AndarEsquerda();
                            Console.WriteLine(obj.Coordenadas());
                        }
                    else if(comando == ConsoleKey.UpArrow && obj.y <= a)
                        {
                            obj.AndarCima();
                            Console.WriteLine(obj.Coordenadas());
                        }
                    else if(comando == ConsoleKey.DownArrow && obj.y > 0)
                        {
                            obj.AndarBaixo();
                            Console.WriteLine(obj.Coordenadas());
                        }
                    else if(comando == ConsoleKey.Escape)
                        {
                            Environment.Exit(0);
                        }

            }








        }
    }
}
