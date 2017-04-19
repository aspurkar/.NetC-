using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfBasic
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int x, int y);
        [OperationContract]
        ComplexNumber AddComplex(ComplexNumber c1, ComplexNumber c2);
    }
}
