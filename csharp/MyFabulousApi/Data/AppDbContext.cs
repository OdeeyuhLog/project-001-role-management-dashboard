using Microsoft.EntityFrameworkCore;
using MyFabulousApi.Models;

namespace MyFabulousApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Member> Members { get; set; }
    }
}
