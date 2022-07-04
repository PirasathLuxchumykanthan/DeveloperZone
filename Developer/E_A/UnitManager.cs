using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_A;

public class UnitManager : Unit
{
    public virtual unit.Type Type => throw new NotImplementedException();
}
