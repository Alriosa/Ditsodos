﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Archer : Troop
    {

        public Archer ()
        {
            troopPrice = 10;
            troopHp = 10;
            troopMovement = 3;
            troopDefense = 3;
            troopAttack = 3;
            troopRange = 4;
            goldCarrying = 2;
        }
        public override int attack()
        {
            throw new NotImplementedException();
        }

        public override int getAttack()
        {
            throw new NotImplementedException();
        }

        public override int getDefense()
        {
            throw new NotImplementedException();
        }

        public override string getDescription()
        {
            string mensaje = "Personaje: Archer\n Precio: " + Convert.ToString(troopPrice);
            mensaje += "\nVida: " + Convert.ToString(troopHp);
            mensaje += "\nCant Mov: " + Convert.ToString(troopMovement);
            mensaje += "\nDefensa: " + Convert.ToString(troopDefense);    
            mensaje += "\nPuntos de ataque: " + Convert.ToString(troopAttack);    
            mensaje += "\nRango de ataque: " + Convert.ToString(troopRange);    
            mensaje += "\nCant oro transportable: " + Convert.ToString(goldCarrying);    
            return mensaje;

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
    }
}
