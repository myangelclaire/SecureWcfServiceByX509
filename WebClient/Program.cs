using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.CalculatorServiceClient client = new ServiceReference1.CalculatorServiceClient();
            Console.WriteLine(client.Add(3, 4));
        }
    }
}
