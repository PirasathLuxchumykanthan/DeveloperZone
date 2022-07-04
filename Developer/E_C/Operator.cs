using E_C.network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_C;

public interface Operator{

    internal event Action Handler;
    internal Status Status { get;  }
}
