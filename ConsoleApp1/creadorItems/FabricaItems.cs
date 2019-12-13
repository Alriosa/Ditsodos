using BusinessLayer.creador;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.creadorItems
{
    public class FabricaItems : IMetodo_Fabrica
    {
        public Troop createTroop(string troop, int player)
        {
            switch (troop)
            {
                case "Archer":
                    return new Archer();
                case "Assasin":
                    return new Assasin();
                case "Berseker":
                    return new Berseker();

                case "Mage":
                    return new Mage();
                case "Rider":
                    return new Rider();
                case "Spy":
                    return new Spy();
                case "Swordman":
                    return new Swordman();
                default:
                    break;
            }
            return null;
        }


        public Defense createDefense(Defense defense, int player)
        {
            switch (defense.GetType().Name)
            {
                case "Crossbow":
                    return new Crossbow();
                case "Catapult":
                    return new Catapult();
                default:
                    break;
            }
            return null;
        }
    }
}
