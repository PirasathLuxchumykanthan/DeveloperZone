using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_B;
public static class Services
{
    public static void NetworkOperator(this IServiceCollection Services)
    {
        Services.AddScoped<E_C.Operator, Operator>();
    }
}