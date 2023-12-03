using Microsoft.EntityFrameworkCore;
using online_order.Models;

namespace online_order.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Category { get; set; }

    }
}
