using Microsoft.EntityFrameworkCore;
using FutureWorkAPI.Models;

namespace FutureWorkAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Career> Careers { get; set; }
    }
}
