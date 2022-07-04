using C_B;
using E_B;
using E_C;
using C_A;
using C_C;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<C.App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.UnitManager();
builder.Services.NetworkOperator();
builder.Services.NetworkManager();
builder.Services.TaskManager();
builder.Services.FileManager();
await builder.Build().RunAsync();
