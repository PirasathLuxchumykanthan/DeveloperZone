using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
namespace E_E
{
    public class EntranceManager:Entrance
    {
        private readonly E_A.Unit Unit;
        public EntranceManager(E_C.Network Network,E_A.Unit Unit) {
            this.Unit = Unit;
            this.OnSaveHeaderKey();
        }
        private HubConnection? _Hub;

        public HubConnection Hub => this._Hub ??= new HubConnectionBuilder().WithAutomaticReconnect().WithUrl("https://object.social/entrance", x => {
            x.Headers.Add("Unit.Type", ((int)Unit.Type).ToString());
            x.Headers.Add("Unit.TwoLetterISOLanguageName", Unit.TwoLetterISOLanguageName);
            x.Headers.Add("Unit.LocalTimezoneId", Unit.LocalTimezoneId);
            x.Headers.Add("Unit.LocalUTCMinutesAddOn", Unit.LocalUTCMinutesAddOn.ToString());
            this.SetHeaderKey(x.Headers);
           
        }).Build();

        public virtual void OnSaveHeaderKey()
        {
            throw new NotImplementedException();
        }

        public virtual void SetHeaderKey(IDictionary<string, string> Headers)
        {
            throw new NotImplementedException();
        }
        

    }
}
