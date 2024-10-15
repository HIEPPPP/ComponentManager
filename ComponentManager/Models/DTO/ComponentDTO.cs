using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Models.DTO
{
    [NotMapped]
    public class ComponentDTO
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Level { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        public string Name { get; set; }

        [StringLength(500)]
        public string Category { get; set; }

        [StringLength(500)]
        public string Provider { get; set; }

        [StringLength(500)]
        public string Secssion { get; set; }
        public int? Quantity { get; set; }
    }
}
