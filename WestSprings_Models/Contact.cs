using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WestSprings_ViewModels
{
    public class WestSprings_Contact
    {
            //public WestSprings_Contact()
            //{
            //    SendToAddress = new List<SelectListItem>();
            //}

            //public int SendToID { get; set; }
            //public IEnumerable<SelectListItem> SendToAddress { get; set; }
            [Required]
            [Display(Name = "Your Email")]
            public string Email { get; set; }
            [Required]
            [Display(Name = "Your Name")]
            public string Name { get; set; }
            [Required]
            [Display(Name = "Your Message")]
            public string Message { get; set; }

        }

        public enum Leadership
        {

            [Display(Name = "Tim McDonnell")]
            TimMcDonnell,
            [Display(Name = "Justin Brunk")]
            JustinBrunk,
            [Display(Name = "Dan Kneehast")]
            DanKneehast,
            [Display(Name = "Gloria McDonnell")]
            GloriaMcDonnell,
            [Display(Name = "Tim Thompson")]
            TimThompson,
            [Display(Name = "Carol Varner")]
            CarolVarner,
            [Display(Name = "Ryan McDonnell")]
            RyanMcDonnell,
            [Display(Name = "Elders of West Springs")]
            EldersofWS,

        }

    }

