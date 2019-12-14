using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Spy : Troop
    {

        public Spy()
        {
            troopPrice = 5;
            troopHp = 2;
            troopMovement = 5;
            troopDefense = 1;
            troopAttack = 1;
            troopRange = 3;
            goldCarrying = 10;
        }

        public override string getDescription()
        {
            string mensaje = "Personaje: Spy\nPrecio: " + Convert.ToString(troopPrice);
            mensaje += "\nVida: " + Convert.ToString(troopHp);
            mensaje += "\nCant Mov: " + Convert.ToString(troopMovement);
            mensaje += "\nDefensa: " + Convert.ToString(troopDefense);
            mensaje += "\nPuntos de ataque: " + Convert.ToString(troopAttack);
            mensaje += "\nRango de ataque: " + Convert.ToString(troopRange);
            mensaje += "\nCant oro transportable: " + Convert.ToString(goldCarrying);
            return mensaje;

        }
        public int stealGold()
        {
            return 0;
        }

        /**
         * Funciones implementadas del objeto abstracto
         * 
         */
        public override int attack()
        {
            throw new NotImplementedException();
        }

        public override int getAttack()
        {
            throw new NotImplementedException();
        }

        public override int getGoldCarrying()
        {
            throw new NotImplementedException();
        }

        public override int getMovements()
        {
            throw new NotImplementedException();
        }

        public override int getPrice()
        {
            throw new NotImplementedException();
        }

        public override int getRange()
        {
            throw new NotImplementedException();
        }

        public override int giveGoldToCastle()
        {
            throw new NotImplementedException();
        }

        public override int getDefense()
        {
            throw new NotImplementedException();
        }
    }
}
