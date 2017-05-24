using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mes = new int[12];
            for (int i = 1; i < mes.Length; i++)
            {
                if (i == 2)
                    mes[i] = mes[i - 1] + 28;
                else if (i % 2 == 0)
                    mes[i] = mes[i - 1] + 30;
                else
                    mes[i] = mes[i - 1] + 31;
            }
            string []mesEx = { " ", "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
            int dia;
            string data;
            Console.WriteLine("Informe a data");
            data = Console.ReadLine();
            if ((data.Substring(1, 1)) == " ")
            {
                dia = Convert.ToInt32(data.Substring(0, 1));
            }
            else
            {
                dia = Convert.ToInt32(data.Substring(0, 2));
            }
            for(int i = 1; i < mes.Length; i++)
            {
                if (mesEx[i] == data.Substring(6, data.Length - 6))
                {
                    Console.WriteLine(mes[i - 1] + dia + "° dia do ano");
                }
            }

           


        }
    }
}
