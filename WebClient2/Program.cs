using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceReference2.CalculatorServiceClient client = new ServiceReference2.CalculatorServiceClient())
            {
                Console.WriteLine(client.GetData(34));
            }
        }
    }
}
