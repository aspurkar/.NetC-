using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace CustomActionResult
{
    public class XmlResult:ActionResult
    {
        private object objToSerialize;
        public XmlResult(object data)
        {
            objToSerialize = data;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            var xs = new XmlSerializer(objToSerialize.GetType());
            var sb= new StringBuilder();
            TextWriter tw = new StringWriter(sb);
            xs.Serialize(tw, objToSerialize);
            tw.Close();
            var xml = sb.ToString();

            context.HttpContext.Response.ContentType = "application/xml";
            context.HttpContext.Response.Write(xml);
        }
    }
}