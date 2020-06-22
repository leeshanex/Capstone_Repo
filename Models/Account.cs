using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Proj.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

       [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }
        public PaymentMethod Payment { get; set; }

    }
}
