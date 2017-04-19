using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // PUT api/values/5
        public void Put([FromBody] string passward, [FromBody]string username)
        {
        }
    }
}
