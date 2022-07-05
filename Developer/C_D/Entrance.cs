using E_A;
using E_C;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using E_E.entrance;

namespace C_D
{
    class Entrance : E_E.EntranceManager, IDisposable
    {
        private DotNetObjectReference<Entrance>? ObjectReference { get; set; }
        private IJSObjectReference? JSObjectReference { get; set; }
        public Entrance(IJSRuntime JSRuntime,Network Network, Unit Unit) : base(Network, Unit)
        {
            JSRuntime.InvokeAsync<IJSObjectReference>("import", $"/_content/C_D/Entrance.js").AsTask().ContinueWith(a => (JSObjectReference = a.Result).InvokeVoidAsync("TryToGetKey", ObjectReference = DotNetObjectReference.Create(this)));
            var a = this.Hub;
        }
        public void Dispose()
        {
            JSObjectReference?.DisposeAsync();
            ObjectReference?.Dispose();
        }
        public override void OnSaveHeaderKey() => this.Hub.On<string, string, C_D.entrance.Storage>("SaveHeaderKey", (Key, Security, Storage) => JSObjectReference?.InvokeVoidAsync("SaveHeaderKey", Key, Security, Storage));

        public override async Task<Data?> GetKey()
        {
          
            return new Data();
        }
    }
}
