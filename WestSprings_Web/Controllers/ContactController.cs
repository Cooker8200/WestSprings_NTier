using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WestSprings_Business;
using WestSprings_ViewModels;

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
            WestSprings_ViewModels.WestSprings_Contact model = new WestSprings_Contact();
            IEnumerable<Leadership> admins = Enum.GetValues(typeof(Leadership)).Cast<Leadership>();
            model.SendToAddresses = from admin in admins
                                    select new SelectListItem
                                    {
                                        Text = admin.ToString(),
                                        Value = ((int)admin).ToString()
                                    };
            return View(model);
        }

        public ActionResult ContactMessage(WestSprings_ViewModels.WestSprings_Contact model)
        {
            if (ModelState.IsValid)
            {
                var date = DateTime.Now;
                var name = User.Identity.Name;
                
                using (StreamWriter email = new StreamWriter("C:/Users/Jennifer/Desktop/WestSprings_NTier/WestSprings_Utilities/Logs/TextFile1.txt ", append: true))
                {
                    
                }
                _contact.SendMessage(model);
                // todo finish loggin code

            }

            else
            {

            }

            return RedirectToAction("ContactHome");
        }

        public ActionResult Sent()
        {
            return PartialView("_Sent");
        }
    }
}