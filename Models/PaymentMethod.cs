using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Proj.Models
{
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodId { get; set; }
        public string PayMethod { get; set; }

    }
}
