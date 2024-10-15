using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Models.DTO
{
    public class ComponentOutDTO
    {
        public string Model { get; set; }
        public int? Quantity { get; set; }
        public DateTime? UsageDate { get; set; }
        public string Reason { get; set; }
        public string RequestBy { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int? Amount { get; set; }
        public string Provider { get; set; }
    }
}
