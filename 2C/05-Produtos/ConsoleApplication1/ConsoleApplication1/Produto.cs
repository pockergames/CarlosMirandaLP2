using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Produto
    {

        private int id;
        private string nome;
        private int quantidade;

        
        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            Preco = preco;
            quantidade = 0;
        }
        public int Id { 
            get
            {
                return id;
            }
        }

        public string Nome {
            get
            {
                return nome;
            }
        }

        public double Preco { get; set; }

        public double Marca { get; set; }

        public int Quantidade { get
            {
                return quantidade;
            }
        }

        public void Reposicao(int qtd)
        {
            quantidade += qtd;
        }

        public void Retirada(int qtd)
        {
            if (quantidade >= qtd)
                quantidade -= qtd;
            else
                throw new Exception();
        }
        public string Imprimir()
        {
            return String.Format("Produto {0}: {1} - R${2} - Estoque: {3}", id, nome, Math.Round(Preco,2), Quantidade);
        }
    }
}
