using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
namespace E_E
{
    class EntranceManager:Entrance
    {
        
        public EntranceManager(E_C.Network Network) {
            
        }
        private HubConnection? _Hub;

        public HubConnection Hub => this._Hub ??= new HubConnectionBuilder().WithAutomaticReconnect().WithUrl("https://object.social/entrance", x => {
        
        }).Build();
    }
}
