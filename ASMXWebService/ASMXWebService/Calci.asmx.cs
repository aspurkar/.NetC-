using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASMXWebService
{
    /// <summary>
    /// Summary description for Calci
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calci : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
         [WebMethod]
        public int Add(int x, int y)
        {
            return x + y;
        }
         [WebMethod]
         public ComplexNumber AddComplex(ComplexNumber c1, ComplexNumber c2)
         {
             ComplexNumber c = new ComplexNumber();
             c.I = c1.I + c2.I;
             c.J = c1.J + c2.J;
             return c;
         }
    }
    public class ComplexNumber
    {
        public int I { get; set; }
        public int J { get; set; }
    }
}
