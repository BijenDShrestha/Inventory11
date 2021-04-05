using Microsoft.EntityFrameworkCore;
using InventoryManagement.Models;

namespace InventoryManagement.Data
{
    public class IMSContext:DbContext
    {
        public IMSContext(DbContextOptions<IMSContext> options):base(options)
        {

        }
        public DbSet<Inventory> Inventories {get; set;}
        public DbSet<Users> Usertable {get; set;}
        public DbSet<Users> NewUsertabel {get; set;}
    }
}