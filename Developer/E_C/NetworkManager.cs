using E_C.network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_C;
class NetworkManager:Network
{
    public NetworkManager(Operator Operator) {
      
        this.Status = Operator.Status;
        Operator.Handler += () =>
        {
            if (this.Status == Operator.Status) return;
            this.Status = Operator.Status;
            this._Handler?.Invoke();
        };
    }
    public Status Status { get; private set; }
    private Action? _Handler;
    public event Action Handler {
        add => _Handler += value;
        remove => _Handler -= value;
    }
}
