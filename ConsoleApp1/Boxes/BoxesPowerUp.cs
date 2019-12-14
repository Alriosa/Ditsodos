using Entities.PowerActions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class BoxesPowerUp : Boxes
    {
        private DateTime time { get; set; }
        private string action { get; set; }
        private int status { get; set; }
        private string color { get; set; }
        //Se agregó un atributo de powerAction
        private PowerUpAction powerAction { get; set; }
    }
}
