using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    interface Rule
    {
        Card[] FindCandidate(Hand hand, Table table);
    }
}
