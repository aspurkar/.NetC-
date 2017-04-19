using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfBasic
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