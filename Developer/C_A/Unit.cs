using E_B;
using E_E;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A
{
    class Unit:E_A.UnitManager
    {
        public Unit(Entrance Entrance, E_A.Credential Credential, Tasks Tasks) : base(Entrance, Credential, Tasks)
        {
        }

        public override E_A.unit.Type Type => E_A.unit.Type.Browser;
        
    }
}
