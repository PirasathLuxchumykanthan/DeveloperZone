using E_A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using E_E.entrance;

namespace A_D
{
    class Entrance : E_E.EntranceManager
    {
        public Entrance(E_C.Network Network, Unit Unit) : base(Network, Unit)
        {

        }
        public override void OnSaveHeaderKey()
        {
            this.Hub.On<string,string>("SaveHeaderKey", async (k, s) => {
                await SecureStorage.Default.SetAsync("Unit.Key", k);
                await SecureStorage.Default.SetAsync("Unit.Key.security", s);
            });
        }
        public override async Task<Data?> GetKey()
        {
            await SecureStorage.Default.GetAsync("Unit.Key").ContinueWith(x => {


            });
            await SecureStorage.Default.GetAsync("Unit.Key.security").ContinueWith(x => {

            });

            return new Data();
        }
    }
}
