using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A;
public static class Services
{
    public static void UnitManager(this IServiceCollection Services)
    {
        Services.AddScoped<E_A.Unit, Unit>();
    }
}
