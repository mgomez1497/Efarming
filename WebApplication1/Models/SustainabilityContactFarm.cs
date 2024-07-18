using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SustainabilityContactFarm
    {
        [Key, Column(Order = 0)]
        public Guid ContactId { get; set; }
        

        [Key, Column(Order = 1)]
        public Guid FarmId { get; set; }
       
    }

    public class ContactRequest
    {
        public SustainabilityContacts Contact { get; set; }
        public SustainabilityContactFarm ContactFarm { get; set; }
        public string FarmId { get; set; }
        public List<int> TopicIds { get; set; }
    }
}