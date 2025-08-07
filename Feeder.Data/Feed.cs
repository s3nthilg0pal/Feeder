namespace Feeder.Data;

public class Feed : IDate
{
    public int Id { get; set; }
    public string Url { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}