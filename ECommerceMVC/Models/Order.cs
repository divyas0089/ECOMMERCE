using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceMVC.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int CartID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Price { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Quantity { get; set; }
    }
}
