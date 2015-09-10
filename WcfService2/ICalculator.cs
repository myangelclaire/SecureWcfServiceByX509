using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    [ServiceContract(Name = "CalculatorService", Namespace = "http://Cookie.com")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x, double y);

        [OperationContract]
        string GetData(int value);
    }
}
