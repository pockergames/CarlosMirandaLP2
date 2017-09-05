using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da medida a ser convertida");
            Conversor.Valor = Console.ReadLine();
            Console.WriteLine(Conversor.ToKg());
            
        }
    }
}
