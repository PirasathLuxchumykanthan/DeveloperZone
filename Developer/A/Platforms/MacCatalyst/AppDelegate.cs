using Foundation;
using Security;

namespace A
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
        public AppDelegate() {

            SecKeyChain.Add(new SecRecord { Service = "social.object.app.microsoft.maui.essentials.preference" });
        }
    }
}