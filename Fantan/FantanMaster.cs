using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class FantanMaster : Master
    {
        public const int PASS_LIMIT = 3;

        public void Pass(FantanPlayer player)
        {
            if(player.GetPass() > PASS_LIMIT)
            {
                Console.WriteLine(player.Name + "さんが敗者です。");
                DeregisterPlayer(player);
            }
        }
    }
}
