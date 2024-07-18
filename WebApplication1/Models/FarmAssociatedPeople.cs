using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FarmAssociatedPeople
    {
        [Key, Column(Order = 0)]
        [ForeignKey ("User")]

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Key,Column(Order = 1)]
        [ForeignKey("Farm")]
        public Guid FarmId { get; set; }
        public virtual Farm Farm { get; set; }

    }
}