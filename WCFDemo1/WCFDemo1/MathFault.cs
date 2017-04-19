using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFDemo1
{
   
    public class MathFault
    {
        public string Message { get; set; }
        public string InvalidParam { get; set; }
    }
}
