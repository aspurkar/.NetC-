using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomControllerFactory
{
    public class ActionInvokerSelector
    {
        public static IActionInvoker GetCurrentActinInvoker()
        {
            return new MyInvoker();
        }
    }
}