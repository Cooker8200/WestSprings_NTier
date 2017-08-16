using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestSprings_Data.DataModel
{
    public class Directory
    {
        
            [Key]
            public int memberid { get; set; }
            public string firstname { get; set; }

            public string lastname { get; set; }

            public string address { get; set; }

            public string city { get; set; }

            public string state { get; set; }

            public string zipcode { get; set; }

            public string phone { get; set; }

            public string email { get; set; }

            public string birthday { get; set; }

            public string anniversary { get; set; }

            public string children { get; set; }

            public string childbirthday { get; set; }
        
    }
}
