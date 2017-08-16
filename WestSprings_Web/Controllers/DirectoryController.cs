using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WestSprings_Business;

namespace WestSprings_Web.Controllers
{
    public class DirectoryController : Controller
    {
        public DirectoryController()
        {
            _directoryManager = new DirectoryManager();
        }

        private DirectoryManager _directoryManager;

        public ActionResult DirectoryHome()
        {
            var DirectoryDbList = _directoryManager.List();
            return View(DirectoryDbList);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}