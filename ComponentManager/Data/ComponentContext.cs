using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using ComponentManager.Models;
using ComponentManager.Models.DTO;

namespace ComponentManager.Data
{
    public partial class ComponentContext : DbContext
    {
        public ComponentContext()
            : base("name=ComponentContext")
        {
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<ComponentIn> ComponentsIn { get; set; }
        public virtual DbSet<ComponentOut> ComponentsOut { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<ImportanceLevels> ImportanceLevels { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Noti> Notis { get; set; }

        //View
        // public DbSet<ComponentInDTO> componentInDTOs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>()
                .Property(e => e.Phone)
                .IsUnicode(false);            
        }
    }
}
