using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace WCFDemo1
{
    public class Calculator : ICalculator, IScientificCalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (Exception ex)
            {
                //var mathFault = new MathFault();
                //mathFault.InvalidParam = "y with value " + y.ToString();
                //mathFault.Message = ex.Message;
                var fx = new FaultException(ex.Message, new FaultCode("MathError"));
                throw fx;
            }
        }

        public ComplexNumber AddComplex(ComplexNumber x, ComplexNumber y)
        {
            var c = new ComplexNumber();
            c.I = x.I + y.I;
            c.J = x.J + y.J;
            return c;
        }

        public double Pow(int x, int y)
        {
            return Math.Pow(x, y);
        }

        public double SqaureRoot(int x)
        {
            return Math.Sqrt(x);
        }
    }
}
