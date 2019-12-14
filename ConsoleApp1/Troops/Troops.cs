using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public abstract class Troop
    {
        protected int troopPrice { get; set; }
        protected int troopHp { get; set; }
        protected int troopDefense { get; set; }
        protected int troopMovement { get; set; }
        protected int troopAttack { get; set; }
        protected int troopRange { get; set; }
        protected int goldCarrying { get; set; }



        public Troop()
        {
            troopPrice = 0;
            troopHp = 0;
            troopDefense = 0;
            troopMovement = 0;
            troopAttack = 0;
            troopRange = 0;
            goldCarrying = 0;
        }

        protected Troop(int troopPrice, int troopHp, int troopDefense, int troopMovement, int troopAttack, int troopRange, int goldCarrying)
        {
            this.troopPrice = troopPrice;
            this.troopHp = troopHp;
            this.troopDefense = troopDefense;
            this.troopMovement = troopMovement;
            this.troopAttack = troopAttack;
            this.troopRange = troopRange;
            this.goldCarrying = goldCarrying;
        }

        public abstract string getDescription();

        public abstract int getAttack();
        public abstract int getDefense();
        public abstract int getRange();
        public abstract int getMovements();
        public abstract int getPrice();
        public abstract int getGoldCarrying();
        public abstract int attack();
        public abstract int giveGoldToCastle();

    }

}
