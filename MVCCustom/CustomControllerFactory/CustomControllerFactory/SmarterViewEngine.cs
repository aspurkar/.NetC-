using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace CustomControllerFactory
{
    public class SmarterViewEngine:IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            throw new NotImplementedException();
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName.Contains("Custom"))
            {
                return new ViewEngineResult(new CustomView(), this);
            }
            else
            {
                return new ViewEngineResult(new string[]{"c:\temp"});
            }
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
          
        }
    }
}