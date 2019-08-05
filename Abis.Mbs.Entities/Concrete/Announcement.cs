using Abis.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Abis.Mbs.Entities.Concrete
{
    public class Announcement : IEntity
    {
        
        public int AnnouncementId { get; set; }
       
        [Required]
        public string ATitle { get; set; }
       
        [Required]
        public string ADescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ACreateDate { get; set; }
        //public bool IsActive { get; set; }



    }
}
