using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompeticaoDeCorrida
{
    class Competidor
    {
        public string nome;
        public double tempo1;
        public double tempo2;
        public double tempo3;

        public double TempoTotal()
        {
            return tempo1 + tempo2 + tempo3;
        }
    }
}
