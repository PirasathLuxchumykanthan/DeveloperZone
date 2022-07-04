using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace E_B;

public interface Tasks
{
    public task.Service[] Services { get; }
    public task.service.Status Status { get; }
    public event Action Handler;
    public task.Service Get(Type Type);
}
