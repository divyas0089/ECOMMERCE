using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceMVC.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string AdminName { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string MobileNO { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Password { get; set; }

    }
}
