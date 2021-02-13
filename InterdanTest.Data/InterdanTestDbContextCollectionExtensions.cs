using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InterdanTest.Data
{
    public static class InterdanTestDbContextCollectionExtensions
    {
        public static IServiceCollection AddInterdanTestDbContext(this IServiceCollection services)
        {
            return services.AddDbContext<InterdanTestDbContext>(options =>
                options.UseInMemoryDatabase("Interdan"));

        }
    }
}
