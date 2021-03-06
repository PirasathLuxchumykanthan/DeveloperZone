using E_A.unit;
using E_B;
using E_E;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A
{
    class Credential : E_A.CredentialManager
    {

        private IJSObjectReference JSObjectReference { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Credential(IJSRuntime JSRuntime, Entrance Entrance, Tasks Tasks) : base(Entrance, Tasks)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            JSRuntime.InvokeAsync<IJSObjectReference>("import", $"/_content/C_A/Credential.js").AsTask().ContinueWith( a => {
                JSObjectReference = a.Result; 
                this.Build();
            });
        }
        public override async Task<string?> Get(string Key)=>
            await JSObjectReference.InvokeAsync<string>("Get", Key);
        public override async Task Set(string Key, string Value)
        {
            await JSObjectReference.InvokeVoidAsync("Set", Key, Value); 
            await base.Set(Key, Value);
        }
    }
}
