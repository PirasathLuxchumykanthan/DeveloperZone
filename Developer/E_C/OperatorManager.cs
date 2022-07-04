using E_C.network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_C
{
    public class OperatorManager : Operator
    {
        private Action? Handler;
        event Action Operator.Handler
        {
            add => Handler += value;
            remove => Handler -= value;
        }

        private Status Status { get; set; }
        Status Operator.Status => this.Status;

    
        public OperatorManager(network.Status Status) => this.Status = Status;

        public virtual void Network(network.Status Status) {
            if (this.Status == Status) return;
            this.Status = Status;
            this.Handler?.Invoke();
        }
    }
}
