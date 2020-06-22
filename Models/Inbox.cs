using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_Proj.Models
{
    public class Inbox
    {
        [Key]
        public int InboxId { get; set; }
        public string MessagesReceived { get; set; }
        public string MessagesSent { get; set; }

        [ForeignKey("Guide")]
        public int GuideId { get; set; }
        public Guide Guide { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
