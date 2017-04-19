using MvcAjax2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAjax2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult addcomment()
        {
            var list = new List<Comment>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Comment() { CommentText = "Comment text for comment " + i, UserName = "User " + i });
            }
            return View(list);
        }
        [HttpPost]
        public ActionResult addcomment(string userName, string commentText)
        {
            var comment = new Comment();
            comment.UserName = userName;
            comment.CommentText = commentText;
            return PartialView("_Comment",comment);
        }
    }
}
