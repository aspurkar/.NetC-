using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace WCFDemo1
{
   [ServiceContract(Namespace = "mydomain.com/mathservice")] 
    public interface IScientificCalculator
    {
         [OperationContract]
        double Pow(int x, int y);
         [OperationContract]
        double SqaureRoot(int x);
    }
}
