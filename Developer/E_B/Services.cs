using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_B;

public static class Services
{
    public static void TaskManager(this IServiceCollection Services) {
        Services.AddScoped<Tasks, TasksManager>();
    }
}
