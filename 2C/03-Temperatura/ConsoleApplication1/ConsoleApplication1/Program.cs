using System;
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
            Console.WriteLine("===========================Temperature Converter BETA 0.1=======================");

            CelciusTemperature x = new CelciusTemperature();

            Console.WriteLine("Insert the temperature value in Celcius (only numbers*)");
            x.value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nValue in Farenheit:");
            Console.WriteLine("\n" + x.FarenheitConvertion() + "°F");
            Console.WriteLine("\nValue in Kelvins:");
            Console.WriteLine("\n" + x.KelvinConvertion() + " K");




        }
    }
}
