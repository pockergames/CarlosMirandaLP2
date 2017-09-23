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
                return "informe a unidade de medida após o número (sem espaços) e verifique se está correta";
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
                return Convert.ToString(numero * 1.8 + 32) + "°F";
            }
            else if (valor[valor.Length - 1] == 'K' || valor[valor.Length - 1] == 'k')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(1.8 * (numero - 273.15) + 32) + "°F";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaK(string valor)
        {
            double numero;

            if (valor[valor.Length - 1] == 'C' || valor[valor.Length - 1] == 'c')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero + 274.15) + "K";
            }
            else if (valor[valor.Length - 1] == 'F' || valor[valor.Length - 1] == 'f')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString((numero + 459.67) * 5 / 9) + "K";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }

        public static string ParaMetros(string valor)
        {
            double numero;

            if (valor[valor.Length - 1] == 'm' && valor[valor.Length - 2] == 'K' || valor[valor.Length - 2] == 'k')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 1000) + "m";
            }
            else if (valor[valor.Length - 1] == 's' && valor[valor.Length - 2] == 'e' || valor[valor.Length - 2] == 'é' && valor[valor.Length - 3] == 'p' || valor[valor.Length - 3] == 'P')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 3));
                return Convert.ToString(numero * 0.3048) + "m";
            }
            else if (valor[valor.Length - 1] == 'e' || valor[valor.Length - 1] == 'é' && valor[valor.Length - 2] == 'p' || valor[valor.Length - 2] == 'P')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 0.3048) + "m";
            }
            else if (valor[valor.Length - 1] == 'l' && valor[valor.Length - 2] == 'o' && valor[valor.Length - 3] == 'P' || valor[valor.Length - 3] == 'p')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 3));
                return Convert.ToString(numero * 0.0254) + "m";
            }

            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaKm(string valor)
        {
            double numero;

            if (valor[valor.Length - 1] == 'm' || valor[valor.Length - 2] == 'M')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero / 1000) + "Km";
            }
            else if (valor[valor.Length - 1] == 'a' && valor[valor.Length - 2] == 'h')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 5));
                return Convert.ToString(numero * 1.60934) + "m";
            }
            else if (valor[valor.Length - 1] == 's' && valor[valor.Length - 2] == 'a')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 6));
                return Convert.ToString(numero * 1.60934) + "m";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaMilhas(string valor)
        {
            double numero;

            if (valor[valor.Length - 1] == 'm' && valor[valor.Length - 2] == 'k' || valor[valor.Length - 2] == 'K')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 0.621371) + " Milhas";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaPes(string valor)
        {
            double numero;

            if (valor[valor.Length - 1] == 'm' || valor[valor.Length - 2] == 'M')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 3.28084) + " Pes";
            }
            else if (valor[valor.Length - 1] == 'l' && valor[valor.Length - 2] == 'o')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 3));
                return Convert.ToString(numero * 0.083333336) + " Pes";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }
        public static string ParaPol(string valor)
        {
            double numero;

            if (valor[valor.Length - 1] == 'm' || valor[valor.Length - 2] == 'M')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 1));
                return Convert.ToString(numero * 39.3701) + " Pol";
            }
            else if (valor[valor.Length - 3] == 'p' || valor[valor.Length - 3] == 'P' && valor[valor.Length - 2] == 'e' || valor[valor.Length - 2] == 'é')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 3));
                return Convert.ToString(numero * 12.00000648) + " Pol";
            }
            else if (valor[valor.Length - 2] == 'p' || valor[valor.Length - 2] == 'P' && valor[valor.Length - 1] == 'e' || valor[valor.Length - 1] == 'é')
            {
                numero = double.Parse(valor.Substring(0, valor.Length - 2));
                return Convert.ToString(numero * 12.00000648) + " Pol";
            }
            else
            {
                return "informe a unidade de medida após o número (sem espaços)";
            }
        }














    }
}
