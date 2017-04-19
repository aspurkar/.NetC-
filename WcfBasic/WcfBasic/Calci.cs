using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfBasic
{
    public class Calci:ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public ComplexNumber AddComplex(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber c = new ComplexNumber();
            c.I = c1.I + c2.I;
            c.J = c1.J + c2.J;
            return c;
        }
    }
}