namespace MyFabulousApi.Models;

public class Node
{
    public int NodeId { get; set; }
    public string? NodeName { get; set; }
    public required string NodeOwner { get; set; }
    public List<Node>? ConnectedNodes { get; set; }
}