using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Models
{
    [Table("UserLogin")]
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
    }
}
