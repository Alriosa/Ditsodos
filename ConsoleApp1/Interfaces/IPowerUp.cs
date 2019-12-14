using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    interface IPowerUp
    {
        void validateCantActived();
        void changePowerUp();
    }
}
