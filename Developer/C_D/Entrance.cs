using E_A;
using E_C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_D
{
    class Entrance : E_E.EntranceManager
    {
        public Entrance(Network Network, Unit Unit) : base(Network, Unit)
        {
        }
        public override void OnSaveHeaderKey()
        {
            base.OnSaveHeaderKey();
        }
        public override void SetHeaderKey(IDictionary<string, string> Headers)
        {
            base.SetHeaderKey(Headers);
        }
    }
}
