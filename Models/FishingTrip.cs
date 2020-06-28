using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Proj.Models
{
    public class FishingTrip
    {
        [Key]
        public int TripId { get; set; }

        [Display(Name = "Trip Date")]
        [DataType(DataType.Date)]
        public DateTime TripDate { get; set; }

        [DataType(DataType.ImageUrl)]
        public string TripPhoto { get; set; }

        public string TripHistory { get; set; }

        [ForeignKey("Guide")]
        public int GuideId { get; set; }
        public Guide Guide { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
