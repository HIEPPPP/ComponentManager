namespace ComponentManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Provider")]
    public partial class Provider
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ContactName { get; set; }

        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public string Note { get; set; }
    }
}
