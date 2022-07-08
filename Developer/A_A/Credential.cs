using E_A.unit;
using E_B;
using E_E;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_A
{
    partial  class Credential : E_A.CredentialManager
    {
        public Credential(Entrance Entrance, Tasks Tasks) : base(Entrance, Tasks)
        {
            this.Build();
        }
        public override async Task<string> Get(string Key)
        {
           
            return await SecureStorage.GetAsync(Key);
        }
        public override async Task Set(string Key, string Value)
        {
            await SecureStorage.SetAsync(Key, Value);
            await base.Set(Key, Value);
        }
    }
}
