using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using E_E.entrance;
using Microsoft.AspNetCore.SignalR.Client;
namespace E_E
{
    class EntranceManager:Entrance
    {
        private readonly E_C.Network Network;
        private readonly E_B.Tasks Tasks;
        private  E_B.task.Service Service => Tasks.Get(this.GetType());
        public EntranceManager(E_C.Network Network,E_B.Tasks Tasks) {

            this.Tasks = Tasks;
            this.Network = Network;
            this.Service.Start(E_B.task.service.Status.Install);

        }
        private E_B.task.Service[]? StartServices = null;

        public void Build(params E_B.task.Service[] Services) {
            if (Services.Length != 0) {
                this.StartServices = Services;
                foreach (var Service in Services)
                {
                    Service.Handler += BuildHeader;
                }

            }
        }

        private void BuildHeader()
        {
            
            //if (this.Network.Status.Equals(E_C.network.Status.Online) && this.StartServices != null && this.StartServices.All(a => a.Status.Equals(E_B.task.service.Status.Done)) && Hub.State.Equals(HubConnectionState.Disconnected)) {
            //    await _Hub?.StartAsync();
            //}   
        }

        private HubConnection? _Hub;
   
        private HubConnection New() => _Hub = new HubConnectionBuilder().WithAutomaticReconnect().WithUrl("https://object.social/entrance", x =>
        {
            foreach (var KeyValuePair in _Headers)
                x.Headers.Add(KeyValuePair);
        }).Build();

        public HubConnection Hub => (_Hub != null && _Hub.State.Equals(HubConnectionState.Disconnected)) ? New() : _Hub ??= New();

        private List<KeyValuePair<string, string>> _Headers => new List<KeyValuePair<string, string>>();
        public void Header(string Key,string value) {
            if (_Headers.Any(a => a.Key == Key))
                _Headers.RemoveAll(a => a.Key == Key);
            _Headers.Add(new KeyValuePair<string, string>(Key, value));
        }
    }
}
