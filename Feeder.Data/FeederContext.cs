using Microsoft.EntityFrameworkCore;

namespace Feeder.Data;

public class FeederContext :  DbContext, IFeederContext
{
    public DbSet<Feed> Feeds { get; set; }

    public FeederContext()
    {
        
    }

    public FeederContext(DbContextOptions<FeederContext> options) : base(options)
    {
        
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}