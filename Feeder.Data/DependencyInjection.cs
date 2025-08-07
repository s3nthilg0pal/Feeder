using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Feeder.Data;

public static class DependencyInjection
{
    public static void AddFeederData(this IHostApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("FeedDb");
        builder.Services.AddDbContext<FeederContext>((options) =>
        {
            options.UseNpgsql(connectionString);

        });

        builder.Services.AddScoped<IFeederContext>(options => options.GetRequiredService<FeederContext>());
    }
}