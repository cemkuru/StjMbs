using Abis.Mbs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abis.Mbs.MvcWebUI.Models
{
    public class JobUpdateViewModel
    {
        public Announcement Product { get; set; }
        public List<Category> Categories { get; set; }
        public Announcement Announcement { get; set; }
        public Job Job { get;  internal set; }
    }
}
