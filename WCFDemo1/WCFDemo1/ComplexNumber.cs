using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WCFDemo1
{
    [DataContract]
    public class ComplexNumber
    {
        [DataMember]
        public int I { get; set; }
        [DataMember]
        public int J { get; set; }
    }
}
