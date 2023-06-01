using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [StringLength(20)]
        public string ShipCity { get; set; }
        [StringLength(20)]
        public string ShipRegion { get; set; }
        // İlişkiler
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }




    }
}
