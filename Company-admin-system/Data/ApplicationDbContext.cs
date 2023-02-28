using Company_admin_system.Models;
using Microsoft.EntityFrameworkCore;

namespace Company_admin_system.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> employees { get; set; }
    }
}
