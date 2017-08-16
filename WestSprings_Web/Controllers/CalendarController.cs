using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WestSprings_Web.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult CalendarHome()
        {
            return View();
        }
    }
}