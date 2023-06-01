using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Surname { get; set; }
        [StringLength(20)]
        public string Duties { get; set; }
        [Required, StringLength(20)]
        public string UserName { get; set; }
        [Required, StringLength(20)]
        public string Password { get; set; }
        [Required]
        public bool Activity { get; set; }
        // ilişkiler

        public ICollection<Order> Orders { get; set; }


    }
}
