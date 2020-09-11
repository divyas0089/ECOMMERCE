using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceMVC.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        public int OrderedID { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Paymentmethod { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Price { get; set; }
    }
}
