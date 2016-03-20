using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    interface Table
    {

        void PutCard(Card[] card);
        Card[][] GetCard();
    }
}
