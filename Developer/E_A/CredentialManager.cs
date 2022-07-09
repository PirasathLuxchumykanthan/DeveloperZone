using E_A.unit;
using E_B.task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_A
{
    public class CredentialManager : Credential
    {

        private readonly E_B.Tasks Tasks;
        public E_B.task.Service Service => this.Tasks.Get(this.GetType());

        private Guid _ClientSecurityKey , _ServerSecurityID;
      

        Guid ServerSecurityID
        {
            get => _ClientSecurityKey;
            set { 
            _ = Set("E_A.ServerSecurityID", (_ServerSecurityID = value).ToString());
            }
        }

        Guid ClientSecurityKey
        {
            get => _ClientSecurityKey;
            set
            {
                _ = Set("E_A.ClientSecurityKey", (_ClientSecurityKey = value).ToString());
            }
        }

        public Guid TestID { get; private set; } = Guid.NewGuid();

        public virtual Task<string?> Get(string Key) {
            throw new Exception();
        }
        public virtual Task Set(string Key, string Value)
        {
            Entrance.Header(Key, Value);
            return Task.CompletedTask;
        }

        private readonly E_E.Entrance Entrance;
  
        public CredentialManager(E_E.Entrance Entrance, E_B.Tasks Tasks)
        {
            this.Entrance = Entrance;
            this.Tasks = Tasks;
            Service.Start(E_B.task.service.Status.Install);
        }
        public async void Build() {
 
            Guid.TryParse(await Get("E_A.ServerSecurityID"), out _ServerSecurityID);
            if (!Guid.TryParse(await Get("E_A.ClientSecurityKey"), out _ClientSecurityKey))
                ClientSecurityKey = Guid.NewGuid();

     
            Service.Stop(E_B.task.service.Status.Install);
        }
    }
}
