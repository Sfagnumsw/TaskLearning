using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MapObjects
{
     interface IArmy
    {
         Army Army { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MapObjects.Interfaces
{
    interface IOwnerable
    {
        int Owner { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MapObjects
{
    interface ITreasure
    {
        Treasure Treasure { get; set; }
    }
}

