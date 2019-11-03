using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    interface IPlayer
    {
        void calculateTime();
        void validateTurn();
        void validateMaxTroops();
        int throwDie();
        void getCastle();
    }
}
