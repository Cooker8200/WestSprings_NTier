using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestSprings_ViewModels.Directory
{
    public class DirectoryListingViewModel
    {
        [Key]
        public int memberid { get; set; }
        public string firstname { get; set; }

        public string lastname { get; set; }
    }
}
