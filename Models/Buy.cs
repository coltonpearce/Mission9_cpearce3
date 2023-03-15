using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_cpearce3.Models
{
    public class Buy
    {
        [Key]
        [BindNever]
        public int BuyId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter at least one address line")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        
        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter ZIP")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country")]
        public string Country { get; set; }
        public string Anonymous { get; set; }
        

    }
}

