using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string CompanyName { get; set; }
        [StringLength(40)]
        public string Authorized { get; set; }

        [StringLength(20)]
        public string City { get; set; }
        [StringLength(20)]
        public string Region { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(30)]
        public string Email { get; set; }

        // İlişkiler 
        public ICollection<Order> Orders { get; set; }




    }
}
