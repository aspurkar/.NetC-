using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    class data {
        public int value { get; set; }


    }
    public class ValidController : ApiController
    {
     
        // GET api/<controller>/5
        [HttpGet]
        public HttpResponseMessage Check(string id, string id1)
        {
            data d = new data();
            if (id.Equals(id1))
            {
                
                d.value = 1;
                return Request.CreateResponse(HttpStatusCode.OK, d);
            }

            d.value = 0;
            return Request.CreateResponse(HttpStatusCode.OK, d);



        }
        
    }
}