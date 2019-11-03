using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface ICastle
    {
        void createTroops();
        void createDefenses();
        void cancelTroops();
        bool valideTroopsCastle();
    }
}
