using Microsoft.Extensions.DependencyInjection;

namespace E_C;
public static class Services
{
    public static void NetworkManager(this IServiceCollection Services)
    {
        Services.AddScoped<Network,NetworkManager>();
    }
}
