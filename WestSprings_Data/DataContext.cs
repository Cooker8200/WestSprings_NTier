using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WestSprings_Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=WestSpringsContext")
        {

        }

        public DbSet<Directories> Directory { get; set; }
    }
}
