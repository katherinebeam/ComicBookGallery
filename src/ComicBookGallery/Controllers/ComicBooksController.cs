using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        /*public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Redirect("/");
                //return new RedirectResult("/");
            }
            return Content("Hello from the ComicBooksController!");

            
            return new ContentResult()
            {
                Content = "Hello from the ComicBooksController!"
            }; 
        } */
        public ActionResult Detail()
        {
            return View();
        }
    }
}