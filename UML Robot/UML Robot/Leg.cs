using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Robot
{
    public class Leg
    {
        int legs;
        int speed;

        public Leg(int legs, int speed)
        {
            this.legs = legs;
            this.speed = speed;
        }
        public int run(int speed)
        {           
            Console.WriteLine("Robot runs at {0} mph",speed);
            return speed;
        }
    }
}
