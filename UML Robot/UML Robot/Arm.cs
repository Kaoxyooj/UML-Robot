using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Robot
{
    class Arm
    {
        int weight;
        float fingers;
        float fist;

        public Arm(int weight, float fingers)
        {
            this.weight = weight;
            this.fingers = fingers;
        }
        public int showWeight(int weight)
        {
            Console.WriteLine("Robot weighs {0}lbs.", weight);
            return weight;
        }

        public float punch(int dmg)
        {
            dmg++;          
            Console.WriteLine("Robot punches for {0} damage", dmg);
            return dmg;
        }
    }
}
