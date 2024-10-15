using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Models.DTO
{
    [NotMapped]
    public class ComponentInDTO
    {
        //public int Id { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public DateTime NgayNhap { get; set; }
        public string Provider { get; set; }
        public double Price { get; set; }
        public string Note { get; set; }
    }
}
