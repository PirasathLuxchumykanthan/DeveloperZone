using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace E_E
{
    public static class Services
    {
        public static void EntranceManager(this IServiceCollection Services)
        {
            Services.AddScoped<Entrance, EntranceManager>();
        }
    }
}
