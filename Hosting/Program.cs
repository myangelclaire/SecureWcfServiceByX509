using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Services;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Opened+=delegate
                {
                    Console.WriteLine("Has started.");
                };
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
