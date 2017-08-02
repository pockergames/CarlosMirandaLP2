using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CelciusTemperature
    {
        public double value;
        public double f;
        public double FarenheitConvertion()
        {
            f = (value * 1.8) + 32;
            return f;
        }

        
    }
}
