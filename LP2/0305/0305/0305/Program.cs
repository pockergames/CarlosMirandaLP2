using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0305
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int vogal = 0;
            s = Console.ReadLine().ToLower();
            
            for(int i = 0; i < s.Length; i++)
            {
                switch(s[i])
                {
                    case 'a': 
                        {
                            vogal++; break;
                        }
                    case 'e':
                        {
                            vogal++; break;
                        }
                    case 'i':
                        {
                            vogal++; break;
                        }
                    case 'o':
                        {
                            vogal++; break;
                        }
                    case 'u':
                        {
                            vogal++; break;
                        }
                }
            }
            Console.WriteLine("Esta mensagem contém {0} vogais", vogal);
        }
    }
}
