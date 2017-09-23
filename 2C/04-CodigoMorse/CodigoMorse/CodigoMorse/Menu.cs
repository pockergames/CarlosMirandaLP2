using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMorse
{
    static class Menu
    {
        public static int Usuario { get; set; }
        public static void Principal()
        {
            Console.WriteLine("                                  Código Morse\n");

            Console.WriteLine("1 - Codificar [ATIVE SEU CAPS LOCK]");
            Console.WriteLine("2 - Decodificar");
            Console.WriteLine("3 - Transmitir");
            Console.WriteLine("0 - Sair");
            Usuario = Convert.ToInt32(Console.ReadLine());
        }
    }


}
