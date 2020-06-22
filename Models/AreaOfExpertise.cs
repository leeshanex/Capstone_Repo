using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Proj.Models
{
    public class AreaOfExpertise
    {
        [Key]
        public int AreaId { get; set; }
        public double PinLocation { get; set; }

        [ForeignKey("Guide")]
        public int GuideId { get; set; }
        public Guide Guide { get; set; }

    }
}
