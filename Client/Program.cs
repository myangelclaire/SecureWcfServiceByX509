using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CalculatorServices.CalculatorServiceClient proxy = new CalculatorServices.CalculatorServiceClient())
            {
                Console.WriteLine(proxy.Add(3, 44));
            }
        }
    }
}
