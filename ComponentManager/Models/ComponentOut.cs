using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Models
{
    [Table("ComponentOut")]
    public class ComponentOut
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public DateTime UsageDate { get; set; }
        public string Reason { get; set; }
        public string RequestBy { get; set; }
        public int Amount { get; set; }
    }
}
