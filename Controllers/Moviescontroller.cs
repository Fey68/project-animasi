using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;

namespace project.Controllers
{
    public class MovieController : Controller
    {
        //Get: movie/random
        public ActionResult random()
        {
            var movie = new Movie() { Name = "Shrek!" , Id= 5 };
            return View(movie);
        }

    }
}