using DorjeDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DorjeDB.Helpers
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ankush> Ankushes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationType> OrganizationTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Contact>().HasOne(p => p.Ankush).WithMany(b=> b.Contacts);
        }
    }
}
