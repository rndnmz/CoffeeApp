using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CoffeBeansTypeId { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        public double Quantity { get; set; }

        public double Discount { get; set; }
        //ilişkiler
        public CoffeeBeansType CoffeeBeansType { get; set; }
        public Order Order { get; set; }

    }
}
