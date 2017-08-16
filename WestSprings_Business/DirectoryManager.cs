using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestSprings_ViewModels;

namespace WestSprings_Business
{
    public class DirectoryManager
    {
        public DirectoryManager()
        {
            _data = new WestSprings_Data.Interface.DataManager();
        }

        private WestSprings_Data.Interface.DataManager _data;

        public IEnumerable<WestSprings_ViewModels.Directory.DirectoryListingViewModel> List()
        {
            var DirectoryList = _data.List();
            return DirectoryList;
        }
    }
}
