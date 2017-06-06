using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Objeto2D
    {
            public int x;
            public int y;
        
        public void AndarDireita()
        {
            x += 3;
        }
        public void AndarEsquerda()
        {
            x -= 3;
        }
    }
}
