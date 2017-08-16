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
        private double preco;

        
        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            Quantidade = 0;
        }
        public int Id { 
            get{
                return this.id;
            }
            
        }

        public string Nome {
            get
            {
                return nome;
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }
        }
        public int Quantidade { get; set; }

        public void Reposicao(int qtd)
        {
            Quantidade += qtd;
        }

        public void Retirada(int qtd)
        {
            if (Quantidade >= qtd)
                Quantidade -= qtd;
            else
                throw new Exception();
        }
        public string Imprimir()
        {
            return String.Format("{0} - {1} - R${2} - {3}", id, nome, preco, Quantidade);
        }
    }
}
