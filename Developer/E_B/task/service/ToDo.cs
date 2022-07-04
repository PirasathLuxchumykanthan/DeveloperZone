using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_B.task.service
{
    internal class ToDo
    {
        internal readonly service.Status Status;
        internal readonly Guid ID;
        internal ToDo(service.Status Status,Guid ID) {
            this.Status = Status;
            this.ID = ID;
        }
    }
}
