using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Questao[] q = new Questao[n];

            for (int i = 0; i < n; i++)
            {
                q[i] = new Questao();
                q[i].a = Convert.ToInt32(Console.ReadLine());
                q[i].b = Convert.ToInt32(Console.ReadLine());
                q[i].c = Convert.ToInt32(Console.ReadLine());
                q[i].d = Convert.ToInt32(Console.ReadLine());
                q[i].e = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(q[i].Certa());
            }
        }
    }
}
