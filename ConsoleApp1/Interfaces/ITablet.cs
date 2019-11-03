using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface ITablet
    {
        void generateTable();
        bool validateTroopsIn();
        void localizeCastles();
        void generateBoxes();
        bool validateLocationBoxes();
    }
}
