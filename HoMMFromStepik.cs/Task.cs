using Inheritance.MapObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.MapObjects
{
    public class Dwelling : IOwnerable // жилище
    {
        public int Owner { get; set; }
    }

    public class Mine : IOwnerable, IArmy, ITreasure // пещера
    {
        public int Owner { get; set; }
        public Army Army { get; set; }
        public Treasure Treasure { get; set; }
    }

    public class Creeps : IArmy, ITreasure // юниты
    {
        public Army Army { get; set; }
        public Treasure Treasure { get; set; }
    }

    public class Wolves : IArmy // волки
    {
        public Army Army { get; set; }
    }

    public class ResourcePile : ITreasure // рудник
    {
        public Treasure Treasure { get; set; }
    }

    public static class Interaction
    {
        public static void Make(Player player, object mapObject)
        {
            if(mapObject is IArmy armObj)
            {
                if (!player.CanBeat(armObj.Army))
                {
                    player.Die();
                }
            }

            if (mapObject is IOwnerable ownObj)
            {
                ownObj.Owner = player.Id;
                return;
            }
            
            if(mapObject is ITreasure tresObj)
            {
                player.Consume(tresObj.Treasure);
            }
        }
    }
}
