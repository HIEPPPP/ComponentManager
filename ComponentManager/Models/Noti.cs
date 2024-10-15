using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Models
{
    [Table("Noti")]
    public class Noti
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string ComponentName { get; set; }
        public string MyProperty { get; set; }
        public string NotiType { get; set; }
        public int Quantity { get; set; }
        public bool IsHandled { get; set; } = false;
    }
}
