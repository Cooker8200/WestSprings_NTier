using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WestSprings_ViewModels;

namespace WestSprings_Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=WestSpringsConnection")
        {

        }

        public DbSet<DataModel.Directory> Directory { get; set; }
        //public DbSet<WestSprings_ViewModels.Directory.DirectoryListingViewModel> DirectoryList { get; set; }
        //public DbSet<WestSprings_ViewModels.Directory.DirectoryViewModel> DirectoryDetails { get; set; }

    }
}
