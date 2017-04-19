using Consume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace Consume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult check()
        {
            
            HttpClient client = new HttpClient();
            //RESTSharp
            string path = "http://localhost:54629/api/valid/check/1/1";
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage resp = client.GetAsync(path).Result;
            resp.EnsureSuccessStatusCode();
            var data = resp.Content.ReadAsStringAsync().Result;
            result res=  JsonConvert.DeserializeObject<result>(data);
            ViewBag.Data = res.value;
            return View("result");
        }

        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            
        }

        private string ActionLink(string path)
        {
            throw new NotImplementedException();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}