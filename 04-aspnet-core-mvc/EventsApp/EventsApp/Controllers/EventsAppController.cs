using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using EventsApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsApp.Controllers
{
    public class EventsAppController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            List<Course> CourseList = GetCourses();
            ViewData["Message"] = CourseList;

            return View();
        }

        private static List<Course> GetCourses()
        {
            var c = new Course();
            List<Course> clist = new List<Course>();

            c.Id = 1;
            c.Title = "CNIT 131";
            c.StartDate = Convert.ToDateTime("01/20/2020");
            c.Type = "Online";

            clist.Add(c);

            var c1 = new Course();
            c1.Id = 2; c1.Title = "CNIT 132";
            c1.StartDate = Convert.ToDateTime("01/15/2020");
            c1.Type = "F2F";

            clist.Add(c1);

            return clist;
        }
    }


}
