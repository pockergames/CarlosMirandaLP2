using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    static class Conversor
    {

        private static string valor;

        public static string Valor
        {
            set
            {
                valor = value;
            }
        }

        public static string ToKg()
        {
            double numero;
            if (valor[valor.Length - 1] == 'g')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));

                return Convert.ToString(numero / 1000) + "Kg";
            }
            else if(valor[valor.Length - 1] == 'T' || valor[valor.Length - 1] == 't')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero * 1000) + "Kg";
            }
            else
            {
                return "KG";
            }
                
        }





    }
}
