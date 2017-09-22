using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    static class Conversor
    {

        public static string ParaKg(string valor)
        {
            double numero;
            if (valor[valor.Length - 1] == 'g' || valor[valor.Length - 1] == 'G')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero / 1000) + "Kg";
            }
            else if (valor[valor.Length - 1] == 'T' || valor[valor.Length - 1] == 't')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero * 1000) + "Kg";
            }
            else if (valor[valor.Length - 1] == 'b' && valor[valor.Length - 2] == 'l' || valor[valor.Length - 2] == 'L')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero / 2.20462) + "Kg";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaG(string valor)
        {
            double numero;
            if (valor[valor.Length - 1] == 'g' || valor[valor.Length - 2] == 'k' || valor[valor.Length - 1] == 'K')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 1000) + "g";
            }
            else if (valor[valor.Length - 1] == 'T' || valor[valor.Length - 1] == 't')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero * 1000000) + "g";
            }
            else if (valor[valor.Length - 1] == 'b' && valor[valor.Length - 2] == 'l' || valor[valor.Length - 2] == 'L')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 453.592) + "g";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaLb(string valor)
        {
            double numero;
            if (valor[valor.Length - 1] == 'g' || valor[valor.Length - 1] == 'G')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero * 0.00220462) + "Lb";
            }
            else if (valor[valor.Length - 1] == 'T' || valor[valor.Length - 1] == 't')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero * 2204.62) + "Lb";
            }
            if (valor[valor.Length - 1] == 'g' || valor[valor.Length - 2] == 'k' || valor[valor.Length - 1] == 'K')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 2.20462) + "Lb";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaT(string valor)
        {
            double numero;
            if (valor[valor.Length - 1] == 'g' || valor[valor.Length - 2] == 'k' || valor[valor.Length - 1] == 'K')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero / 1000) + "T";
            }
            else if (valor[valor.Length - 1] == 'g' || valor[valor.Length - 1] == 'G')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero / 1000000) + "T";
            }
            else if (valor[valor.Length - 1] == 'b' && valor[valor.Length - 2] == 'l' || valor[valor.Length - 2] == 'L')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 0.000453592) + "T";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaC(string valor)
        {
            double numero;
            
            if (valor[valor.Length - 1] == 'F' || valor[valor.Length - 1] == 'f')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString((numero - 32) / 1.8 ) + "°C";
            }
            else if (valor[valor.Length - 1] == 'K' || valor[valor.Length - 1] == 'k')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero + 273.15) + "°C";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaF(string valor)
        {
            double numero;

            if (valor[valor.Length - 1] == 'C' || valor[valor.Length - 1] == 'c')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero * 1.8 + 32) + "°C";
            }
            else if (valor[valor.Length - 1] == 'K' || valor[valor.Length - 1] == 'k')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(1.8 * (numero - 273.15) + 32) + "°C";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }










    }
}
