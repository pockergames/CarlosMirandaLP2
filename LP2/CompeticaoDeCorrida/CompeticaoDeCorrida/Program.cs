using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompeticaoDeCorrida
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int n, i;
            double menorTempo;
            int vencedor;


            n = Convert.ToInt32(Console.ReadLine());

            Competidor[] corredor = new Competidor[n + 1];
            
            
            for (i = 1; i <= n; i++)
            {
                corredor[i] = new Competidor();
                corredor[i].nome = Console.ReadLine();
            }
            for (i = 1; i <= n; i++)
            {
                corredor[i].tempo1 = int.Parse(Console.ReadLine());
                corredor[i].tempo2 = int.Parse(Console.ReadLine());
                corredor[i].tempo3 = int.Parse(Console.ReadLine());
            }

            
            for (i = 1; i <= n; i++)
            {
                menorTempo = corredor[i].TempoTotal();
                if (corredor[i].TempoTotal() < menorTempo)
                {
                    menorTempo = corredor[i].TempoTotal();
                    vencedor = i;
                }
                
            }
            
                Console.WriteLine(corredor[vencedor].nome);






        }
        }
    }

