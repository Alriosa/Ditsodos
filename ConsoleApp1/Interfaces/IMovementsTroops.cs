using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    interface IMovementsTroops
    {
        void move();
        void getGold();
        void regenerateDefense();
        void validateRangeAttack();
        void validateMoves();
    }
}
