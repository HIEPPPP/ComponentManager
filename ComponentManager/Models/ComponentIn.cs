using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Models
{
    [Table("ComponentIn")]
    public class ComponentIn
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public DateTime NgayNhap { get; set; }  
        public string Provider { get; set; }
        public double Price {  get; set; }  
        public string Note { get; set; }
        public int Amount { get; set; }
    }
}
