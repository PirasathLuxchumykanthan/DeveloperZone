
using Microsoft.AspNetCore.Components.WebView.Maui;
using E_B;
using E_C;
using A_B;
using A_A;
using A_D;
namespace A
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>();
            builder.Services.UnitManager();
            builder.Services.NetworkOperator();
            builder.Services.NetworkManager();
            builder.Services.TaskManager();
            builder.Services.EntranceManager();

            builder.Services.AddMauiBlazorWebView();


#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            return builder.Build();
        }
    }
}