using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.creador
{
    public interface IMetodo_Fabrica
    {
        Troop createTroop(string troop, int player);
        Defense createDefense(Defense defense, int player);
    }
}
