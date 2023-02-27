﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilveSeyahat.Models.Classlar;

namespace TatilveSeyahat.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            var blog = c.Blogs.ToList();
            return View(blog);
        }
    }
}