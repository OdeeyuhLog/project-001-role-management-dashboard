namespace MyFabulousApi.Models;

public class Board
{
  public int BoardId { get; set; }
  public string? BoardName { get; set; }
  public User[]? Users { get; set; }
  public string? BoardDescription { get; set; }
}
