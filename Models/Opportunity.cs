using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerTracking.Models
{
    public class Opportunity
    {
        [Display(Name = "Opportunity ID")]
        public int OpportunityId { get; set; }

       
        [Required]
        [Display(Name = "Opportunity Name")]
        public string OpportunityName { get; set; }

        
        [Required]
        [Display(Name = "Opportunity Date")]
        [DataType(DataType.Date)]
        public DateTime OpportunityDate { get; set; }

      
        [Required]
        [Display(Name = "Event Day")]
        public DayOfEvent EventDay { get; set; }

       
        [Required]
        [Display(Name = "Event Center")]
        public Center EventCenter { get; set; }
    }

    public enum DayOfEvent
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
