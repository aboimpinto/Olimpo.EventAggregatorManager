using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Olimpo
{
    public static class EventAggregatorHostBuilder
    {
        public static IHostBuilder RegisterEventAggregatorManager(this IHostBuilder builder)
        {
            builder.ConfigureServices((hostContext, services) => 
            {
                services.AddSingleton<IEventAggregator, EventAggregator>();
            });

            return builder;
        }  
    }
}