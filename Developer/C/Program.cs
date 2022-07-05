using C_B;
using E_B;
using E_C;
using C_A;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using C_D;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<C.App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.UnitManager();
builder.Services.NetworkOperator();
builder.Services.NetworkManager();
builder.Services.TaskManager();
builder.Services.EntranceManager();

await builder.Build().RunAsync();
