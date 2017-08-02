using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesPerHour, bookQtd;
            double hoursN, daysN, hoursPerDay;

            Console.WriteLine("Informe a quantidade de livros");

            bookQtd = int.Parse(Console.ReadLine());
            Book[] livro = new Book[bookQtd];

            Console.WriteLine("Informe a quantidade de páginas lidas por hora");
            pagesPerHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas disponível para leitura por dia");
            hoursPerDay = double.Parse(Console.ReadLine());
            
            for (int i = 0; i < bookQtd; i++)
            {
                
                livro[i] = new Book();
                Console.WriteLine("Informe o nome do livro {0}", i + 1);
                livro[i].name = Console.ReadLine();
                Console.WriteLine("Informe a quantidade de páginas do livro {0}", i + 1);
                livro[i].pageN = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tempo restante para devolução do livro {0}", i + 1);
                livro[i].leftT = int.Parse(Console.ReadLine());
                hoursN = livro[i].pageN / pagesPerHour;
                daysN = hoursN / hoursPerDay;

                if (livro[i].leftT < daysN)
                {
                    Console.WriteLine("O livro {0} é impossível de ser lido", livro[i].name);
                }
                else
                {
                    Console.WriteLine("São necessárias {0} dias para ler o livro {1}", daysN, livro[i].name);
                }
            }
        }
    }
}
