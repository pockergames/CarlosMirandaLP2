﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(1, "Sabonete O Cara 100g", 10.123432);
            p.Reposicao(100);
            p.Retirada(20);

            Console.WriteLine(p.Imprimir());
        }
    }
}
