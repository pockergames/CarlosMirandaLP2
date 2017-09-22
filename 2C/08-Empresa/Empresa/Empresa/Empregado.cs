using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Empregado
    {
        private string registro;

        public string Registro
        {
            get
            {
                return registro;
            }
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public string DataEntrada { get; set; }

        private Gerente superior = new Gerente();
        public Gerente Superior
        {
            get
            {
                return superior;
            }
            set
            {
                superior = value;
            }
        }
        public Empregado (string registro, string idGerente)
        {
            this.registro = registro;
            superior.MudarRegistro(idGerente);
        }



    }
}
