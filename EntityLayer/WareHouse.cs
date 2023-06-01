using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class WareHouse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Authorized { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(20)]
        public string Region { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [StringLength(150)]
        public string Adress { get; set; }
        // ilişkiler
        public ICollection<CoffeeBeansType> CoffeeBeansTypes { get; set; }


    }
}
