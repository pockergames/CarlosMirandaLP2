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
            Objeto2D obj = new Objeto2D();

            Console.WriteLine("Digite a posição X do objeto:");
            obj.x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a posição Y do objeto:");
            obj.y = Int32.Parse(Console.ReadLine());
            
            ConsoleKey comando = Console.ReadKey().Key; //"ConsoleKey" é um tipo de variável; "Key" faz o o pc retornar a informação da letra
            if (comando == ConsoleKey.RightArrow)
            {
                obj.AndarDireita;
            }

        }
    }
}
