using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Castle
{
    public class Castle
    {
        private int castleHp { get; set; }
        private bool castleStatus { get; set; }
        private int castleGold { get; set; }
        private int castleTroops { get; set; }
        private bool max_crossbow { get; set; }
        private bool max_catapult { get; set; }
        private List<Troops> troopsReserved { get; set; }

        public void createTroops()
        {

        }

        public void createDefenses()
        {

        }

        public void cancelTroops()
        {

        }
    }
}
