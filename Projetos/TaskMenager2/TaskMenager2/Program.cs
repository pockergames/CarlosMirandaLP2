using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenager2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tarefa[] tfs = new Tarefa[10000];
            for(int i = 0; i < tfs.Length; i++)
            {
                tfs[i] = new Tarefa();
            }
            for (int i = 0; i < tfs.Length; i++)
            {
                tfs[i].Duracao = int.Parse(Console.ReadLine());
            }*/

            int n = int.Parse(Console.ReadLine());
            Dia d = new Dia();
            for (int i = 0; i < n; i++)
            {
                d.TfsDoDia[i] = new Tarefa();

                Console.WriteLine("Nome:\n");
                d.TfsDoDia[i].Nome = Console.ReadLine();
                Console.WriteLine("Prioridade:\n");
                d.TfsDoDia[i].Prioridade = int.Parse(Console.ReadLine());
                Console.WriteLine("Duração:\n");
                d.TfsDoDia[i].Duracao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(d.MostrarTarefas());
        }

    }
}
