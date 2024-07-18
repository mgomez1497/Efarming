using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SustainabilityContactTopic
    {
        [Key, Column(Order = 0)]
      

        public Guid ContactId { get; set; }
        

        [Key, Column(Order = 1)]
        
        public int TopicId { get; set; }
        
    }
}