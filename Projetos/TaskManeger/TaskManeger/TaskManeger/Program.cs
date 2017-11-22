using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManeger
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarefa[] tarefaPorDia = new Tarefa[8760];
            Console.WriteLine("1 - Criar nova Tarefa");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                Console.WriteLine("Nome:");
                string nme = Console.ReadLine();
                Console.WriteLine("Prioridade:");
                int pdade = int.Parse(Console.ReadLine());
                Tarefa tf = new Tarefa(nme, pdade);
                Console.Clear();
                Console.WriteLine("Tarefa Criada com Sucesso!\n{0} - {1}\n", tf.Nome, tf.Prioridade);
                Console.WriteLine("1 - Alocar!");
                if(Console.ReadLine() == "1")
                {

                }
            }

            for (int id = 0; id< 8760; id++)
            {
                tarefaPorDia[id] = new Tarefa("kk", 1);
            }

        }
    }
}
