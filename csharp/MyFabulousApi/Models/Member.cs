using System.ComponentModel.DataAnnotations;

namespace MyFabulousApi.Models;

public class Member
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = "";
    public string Role { get; set; } = "";
}
