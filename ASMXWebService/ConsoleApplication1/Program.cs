using ConsoleApplication1.ServiceRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calci client = new Calci();
            client.Url = "http://localhost:1125/Calci.asmx";
            Console.WriteLine(client.Add(1, 5));
            ComplexNumber c1 = new ComplexNumber { I = 4, J = 5 };
            ComplexNumber c2 = new ComplexNumber { I = 3, J = 4 };
            var c = client.AddComplex(c1, c2);
            Console.WriteLine(c.I +" + "+ c.J + "j");
            Console.Read();
        }
    }
}
