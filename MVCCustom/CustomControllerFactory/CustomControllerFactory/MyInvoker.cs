using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomControllerFactory
{
    public class MyInvoker:IActionInvoker
    {
        public bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            var ctrl = controllerContext.Controller;
            var mInfo= ctrl.GetType().GetMethod(actionName);
            mInfo.Invoke(ctrl, null);
            return true;
        }
    }
}