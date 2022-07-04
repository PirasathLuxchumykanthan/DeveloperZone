using E_C.network;

namespace A_B;
class Operator : E_C.OperatorManager
{
    public Operator() : base(Microsoft.Maui.Networking.Connectivity.Current.NetworkAccess == NetworkAccess.Internet ? Status.Online : Status.Offline)=> Connectivity.ConnectivityChanged += (s, e) => this.Network(Microsoft.Maui.Networking.Connectivity.Current.NetworkAccess == NetworkAccess.Internet ? Status.Online : Status.Offline);
}