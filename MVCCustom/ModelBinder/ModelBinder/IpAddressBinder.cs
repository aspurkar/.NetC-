using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ModelBinder
{
    public class IpAddressBinder:IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            List<System.Net.IPAddress> ipAddress = new List<System.Net.IPAddress>();
            string domains =controllerContext.HttpContext.Request.Form["domains"];
            if (!String.IsNullOrEmpty(domains))
            {
                var ipList = domains.Split(',');
                foreach (var ip in ipList)
                {
                    System.Net.IPAddress ipAddr = null;
                    if (System.Net.IPAddress.TryParse(ip, out ipAddr))
                    {
                        ipAddress.Add(ipAddr);
                    }
                }
            }
            return ipAddress;
        }
    }
}