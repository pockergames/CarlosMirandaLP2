using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Circulo
    {
        public int x, y, raio;
        public string cor;

        public void AndarDireita()
        {
            x += 3;
        }
        public void AndarEsquerda()
        {
            x -= 3;
        }
        public void AndarCima()
        {
            y += 3;
        }
        public void AndarBaixo()
        {
            y -= 3;
        }
        

        public string Coordenadas()
        {
            string coord;
            coord = ("(" + x + "," + y + ")");
            return coord;
        }


    }
}
