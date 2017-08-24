using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestSprings_ViewModels;

namespace WestSprings_Data.Interface
{
    public class DataManager
    {
        private DataContext db = new DataContext();

        public IEnumerable<DataModel.Directory> List()
        {
            var DbList = db.Directory.ToList();
            return DbList;
            //return null;
        }
    }
}
