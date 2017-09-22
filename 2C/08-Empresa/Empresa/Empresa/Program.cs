using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente ger = new Gerente("001", 10);
            ger.Nome = Console.ReadLine();
            Empregado emp = new Empregado("001", "001");
            Console.WriteLine(emp.Superior.Registro);

        }
    }
}
