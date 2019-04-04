using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioFibonacci" in both code and config file together.
    [ServiceContract]
    public interface IServicioFibonacci
    {
        [OperationContract]
        List<int> GetNumerosFibonacci(int num);
    }
}
