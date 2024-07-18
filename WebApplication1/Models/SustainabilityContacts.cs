using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SustainabilityContacts
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

       
       
        public int LocationId { get; set; }
      

        
        
        public int TypeId { get; set; }
       

        
        public string UserId { get; set; }
        

        

    }
}