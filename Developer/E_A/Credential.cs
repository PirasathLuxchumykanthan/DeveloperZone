using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_A;

public interface Credential
{
    
    public E_B.task.Service Service { get; }
    public Guid TestID { get; }
}
