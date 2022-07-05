using E_C.network;
using Microsoft.JSInterop;

namespace C_B;
class Operator : E_C.OperatorManager, IDisposable
{
    private DotNetObjectReference<Operator>? ObjectReference { get; set; }
    private IJSObjectReference? JSObjectReference { get; set; }
    public Operator(IJSRuntime JSRuntime) : base(Status.Online) => JSRuntime.InvokeAsync<IJSObjectReference>("import", $"/_content/C_B/Operator.js").AsTask().ContinueWith(a =>(JSObjectReference = a.Result).InvokeVoidAsync("Operator", 
        ObjectReference = DotNetObjectReference.Create(this)));
    [JSInvokable]
    public override void Network(Status Status) => base.Network(Status);

    public void Dispose()
    {
        JSObjectReference?.DisposeAsync();
        ObjectReference?.Dispose();
    }
}