using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Empregado : Funcionario
    {
       

        public string DataEntrada { get; set; }

        protected Gerente superior = new Gerente();
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
