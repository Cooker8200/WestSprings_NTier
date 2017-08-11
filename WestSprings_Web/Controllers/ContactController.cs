using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WestSprings_Business;

namespace WestSprings_Web.Controllers
{
    public class ContactController : Controller
    {
        public ContactController()
        {
            _contact = new ContactManager();
        }

        private ContactManager _contact;

        public ActionResult ContactHome()
        {
            return View();
        }

        public ActionResult ContactMessage(WestSprings_ViewModels.WestSprings_Contact model)
        {
            if (ModelState.IsValid)
            {
                _contact.SendMessage(model);
                //todo log action
                
            }

            else
            {

            }

            return RedirectToAction("ContactHome");
        }
    }
}