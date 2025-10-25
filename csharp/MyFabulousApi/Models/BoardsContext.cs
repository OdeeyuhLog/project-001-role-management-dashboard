using Microsoft.EntityFrameworkCore;
namespace MyFabulousApi.Models;

public class BoardsContext : DbContext
{
    public BoardsContext(DbContextOptions<BoardsContext> options) : base(options)
    {
    }

    public DbSet<Board> Boards { get; set; } = null!;
    public DbSet<User> Users { get; set; }
}