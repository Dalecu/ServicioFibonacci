using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioFibonacci" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioFibonacci.svc or ServicioFibonacci.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioFibonacci : IServicioFibonacci
    {
        public List<int> GetNumerosFibonacci(int num)
        {
            List<int> FibonacciList = new List<int>();
            int a = 1, b = 0;
            // Secuencia fibonacci
            for (int i = 0; i < num; i++)
            {
                int tmp = a;
                a = b;
                b = tmp + b;
                FibonacciList.Add(b);
            }
            return FibonacciList;
        }
    }
}
