using Microsoft.EntityFrameworkCore;

namespace Feeder.Data;

public interface IFeederContext
{
    DbSet<Feed> Feeds { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}