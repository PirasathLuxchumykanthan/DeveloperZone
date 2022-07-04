using Microsoft.AspNetCore.SignalR;
namespace B_A;
public class Connection:Hub
{
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }
    public override Task OnDisconnectedAsync(Exception exception)
    {
        return base.OnDisconnectedAsync(exception);
    }
}