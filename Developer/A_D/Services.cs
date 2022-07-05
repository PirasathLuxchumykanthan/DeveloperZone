using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_D
{
    public static class Services
    {
        public static void EntranceManager(this IServiceCollection Services)
        {
            Services.AddScoped<E_E.Entrance, Entrance>();
        }
    }

}
