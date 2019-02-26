using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Vehicles
    {
        public string engineSound;
        public string speed;
        public string shoots;
    }

    public class H60RHelicopters : Vehicles
    {
        public H60RHelicopters(string engineSound, string speed, string shoots)
        {
            this.engineSound = engineSound;
            this.speed = speed;
            this.shoots = shoots;
        }
    }

    public class FA18Jets : Vehicles
    {
        public FA18Jets(string engineSound, string speed, string shoots)
        {
            this.engineSound = engineSound;
            this.speed = speed;
            this.shoots = shoots;

        }
    }
}
