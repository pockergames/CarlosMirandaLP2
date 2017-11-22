using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenager2
{
    class Dia
    {
        public string Data { get; set; }
        public Tarefa[] TfsDoDia = new Tarefa[10000];

        public string MostrarTarefas()
        {
            string txt = "\n";
            for (int i = 0; i < TfsDoDia.Length; i++)
            {
                txt += TfsDoDia[i].Nome + " - " + Convert.ToString(TfsDoDia[i].Prioridade) + " - " + Convert.ToString(TfsDoDia[i].Duracao);
            }
            return txt;
        }

    }
}
