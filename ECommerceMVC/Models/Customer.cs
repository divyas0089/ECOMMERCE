using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceMVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [Required]
        public string CustomerName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string MobileNO { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Address { get; set; }

    }
}
