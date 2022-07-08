using Microsoft.AspNetCore.SignalR.Client;
namespace E_E
{
    public interface Entrance
    {
        public HubConnection Hub { get; }
        public void Build(params E_B.task.Service[] Services);
        public void Header(string Key, string value);
    }
}