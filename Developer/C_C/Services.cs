using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C_C;
public static class Services
{
    public static void FileManager(this IServiceCollection Services)
    {
        Services.AddScoped<E_D.File, FileManager>();
    }
}