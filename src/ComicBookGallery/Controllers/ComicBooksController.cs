using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[] 
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" }
                }
            };

            // ViewBag.SeriesTitle = "The Amazing Spiderman";
            // ViewBag.IssueNumber = 700;
            // ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            // ViewBag.Artists = new string[]
            // {
                // "Script: Dan Slott",
                // "Pencils: Humberto Ramos",
                // "Inks: Victor Olazaba",
                // "Colors: Edgar Delgado",
                // "Letters: Chris Eliopoulos"
            // };
            return View(comicBook);
        }
    }
}