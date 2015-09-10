using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebClient3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceReference1.CalculatorServiceClient client = new ServiceReference1.CalculatorServiceClient())
            {
                Console.WriteLine(client.Add(34.2, 34.3));
            }
        }
    }
}
