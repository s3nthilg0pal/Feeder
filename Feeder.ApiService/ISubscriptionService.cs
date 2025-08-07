using Feeder.Data;

namespace Feeder.ApiService;

public interface ISubscriptionService
{
    Task AddFeed(string feedUrl, CancellationToken cancellationToken);
}

public class SubscriptionService : ISubscriptionService
{
    private readonly IFeederContext _context;

    public SubscriptionService(IFeederContext context)
    {
        _context = context;
    }
    
    public async Task AddFeed(string feedUrl, CancellationToken cancellationToken)
    {
        var newFeed = new Feed()
        {
            Active = true,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Url = feedUrl
        };
        _context.Feeds.Add(newFeed);

        await _context.SaveChangesAsync(cancellationToken);
    }
}