using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.ServiceRef1;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();
            Console.WriteLine(client.Add(1, 7));
            Console.Read();
        }
    }
}
