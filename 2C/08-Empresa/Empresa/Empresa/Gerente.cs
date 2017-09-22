using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Gerente
    {

        private string registro;

        public string Registro{ get{
                return registro;                
            }
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public string Setor { get; set; }
        public double Bonus { get; set; }

        public Gerente()
        {

        }
        public Gerente(string registro, double bonus)
        {
            this.registro = registro;
            Bonus = bonus / 100;
        }
        
        public void Pagamento(double valor)
        {
            Salario = valor * Bonus;
        }
        public void MudarRegistro(string registro)
        {
            this.registro = registro;
        }
       


    }
}
