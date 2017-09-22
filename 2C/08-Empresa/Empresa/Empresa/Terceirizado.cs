using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Terceirizado : Empregado
    {

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

        public string EmpresaMatriz { get; set; }
        public Terceirizado (string registro, string idGerente) : base (registro, idGerente)
        {
            this.registro = registro;
            superior.MudarRegistro(idGerente);
        }

    }
}
