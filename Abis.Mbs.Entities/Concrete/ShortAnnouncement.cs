using Abis.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Abis.Mbs.Entities.Concrete
{
    public class ShortAnnouncement:IEntity
    {

        [Key]
        public int ID { get; set; }

       
        public string Title { get; set; }
        
        public string Information { get; set; }

        
        public string Click { get; set; }
    }
}
