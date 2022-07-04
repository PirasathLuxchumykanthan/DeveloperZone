using Microsoft.AspNetCore.SignalR.Client;
namespace E_E
{
    public interface Entrance
    {
        public HubConnection Hub { get; }
    }
}