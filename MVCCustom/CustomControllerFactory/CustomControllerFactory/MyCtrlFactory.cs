using CustomControllerFactory.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CustomControllerFactory
{
    public class MyCtrlFactory:IControllerFactory
    {
      
        public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
           var handle=  Activator.CreateInstance("CustomControllerFactory", "CustomControllerFactory.Controllers." + controllerName);
           return handle.Unwrap() as IController;
            //if(controllerName.ToLower()=="home")
            //{
            //    return new Home();
            //}
            //else 
            //{
            //    throw new Exception("Sorry no such controller");
            //}
        }

        public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            return System.Web.SessionState.SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
           // throw new NotImplementedException();
        }
    }

    
}