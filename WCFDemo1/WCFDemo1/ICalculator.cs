using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace WCFDemo1
{
    [ServiceContract(Namespace="mydomain.com/mathservice")]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int x,int y);

        [OperationContract]
        int Multiply(int x, int y);

         [OperationContract]
         [FaultContract(typeof(MathFault))]
        int Divide(int x, int y);

        [OperationContract]
        ComplexNumber AddComplex(ComplexNumber a, ComplexNumber y);
    }
}
