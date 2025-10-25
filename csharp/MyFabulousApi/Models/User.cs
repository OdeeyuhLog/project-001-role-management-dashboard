using System.ComponentModel.DataAnnotations;

namespace MyFabulousApi.Models;

public class User
{
    public int Id { get; set; }
    [StringLength(100)]
    public string? Name { get; set; }  
    [StringLength(255)]
    public string? Email { get; set; }
    [StringLength(100)]
    public string? PasswordHash { get; set; }
    [StringLength(100)]
    public string? Role { get; set; }
    public Board[]? Boards { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
