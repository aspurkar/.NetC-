using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfClient.ServiceReference1;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client=null;
            ScientificCalculatorClient client2=null;
            try
            {
                client = new CalculatorClient("BasicHttpBinding_ICalculator");
                client2 = new ScientificCalculatorClient("BasicHttpBinding_IScientificCalculator");
               // int res = client.Add(5, 3);
              //  var c1 = new ComplexNumber() { I = 1, J = 2 };
              //  var c2 = new ComplexNumber() { I = 2, J = 3 };
              //  var c3 = client.AddComplex(c1, c2);
              //  int res = client.Divide(5, 0);
                Console.WriteLine(client2.Pow(2, 4));
               // Console.WriteLine(c3.I + "+" + c3.J + "j");
                Console.Read();
                client.Close();
            }
            //catch (FaultException<MathFault> fx)
            //{
            //    var fault = fx.Detail;
            //    Console.WriteLine(fault.InvalidParam);
            //    Console.WriteLine(fault.Message);
            //    Console.Read();
            //    client.Abort();
            //}
            catch (FaultException fx)
            {
                Console.WriteLine(fx.Reason);
                Console.Read();
                client.Abort();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                client.Abort();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                client.Abort();
            }
        }
    }
}
