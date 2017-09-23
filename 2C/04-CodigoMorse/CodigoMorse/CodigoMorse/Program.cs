using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu.Principal();
            Mensagem msg = new Mensagem();
            if (Menu.Usuario == 1)
            {
                Console.WriteLine(msg.Codificar(Console.ReadLine()));
            }
            else if(Menu.Usuario == 2)
            {
                Console.WriteLine(msg.Decodificar(Console.ReadLine()));
            }
            else if (Menu.Usuario == 3)
            {
                Console.WriteLine("Em construção, aguarde...");
            }
            else
            {
                Environment.Exit(0);
            }







        }
    }
}
