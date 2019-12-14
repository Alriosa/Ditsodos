using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    interface IBoxesPowerUp
    {
        void generatePowerUps();
        void activePowerUp(bool active);
        bool isActived();
    }
}
