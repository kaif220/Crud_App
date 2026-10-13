using FirstMvcProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMvcProject.Data
{
    public class AppDbContext(DbContextOptions < AppDbContext > options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        
    }
}
