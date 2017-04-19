using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomControllerFactory
{
    public class CustomView:IView
    {
        public void Render(ViewContext viewContext, System.IO.TextWriter writer)
        {
            writer.WriteLine("Hello this is custom view");
        }
    }
}