using ASP.NET_Warehouse_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ASP.NET_Warehouse_System.Data
{
    class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Warehouse> Warehouses {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options){

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}