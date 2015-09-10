using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service2 : ICalculator
    {

        public double Add(double x, double y)
        {
            return x + y;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
