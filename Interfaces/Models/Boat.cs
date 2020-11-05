using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Boat : AutoMobile, IAutoMobileActions, IBoatActions
    {

        public Boat()
        {

        }

        public Boat(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        public void SteerLeft()
        {
            Console.WriteLine("The boat is steering left");
        }

        public void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }

        public void SteerRight()
        {
            Console.WriteLine("The boat is steering right");
        }

        public void Steer(bool steerLeft)
        {
            if (steerLeft)
            {
                Console.WriteLine("The boat is steering left");
            }
            
        }
    }
}
