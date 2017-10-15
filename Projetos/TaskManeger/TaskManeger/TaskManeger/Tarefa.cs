using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManeger
{
    class Tarefa
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int Prioridade { get; set; }
        public string Nome { get; set; }
        public double qtdHoras { get; set; }

        public Tarefa(string nome, int prioridade)
        {
            Nome = nome;
            Prioridade = prioridade;
        }
        

        
    }
}
