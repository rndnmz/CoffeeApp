using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CoffeeBeansType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public int WareHouseId { get; set; }
        public double UnitPrice { get; set; }
        [StringLength(200)]
        public string Description { get; set; }

        //ilişkiler

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<WareHouse> WareHouses { get; set; }
    }
}
