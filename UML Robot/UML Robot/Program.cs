using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Arm arm = new Arm(400,5);
            Leg leg = new Leg(2,80);
            SlowWingsBody wings = new SlowWingsBody();
            Cannon cannon = new Cannon(5);
            Gatling gatling = new Gatling(100);
            Head head = new Head();

            head.eyeScan();
            Console.WriteLine("~Enemy detected!~");
            leg.run(50);
            arm.punch(0);
            wings.fly();


            gatling.shoot(0);
            Console.WriteLine("The Gatling Gun is not very effective.");
            cannon.shoot(0);
            cannon.shoot(0);
            cannon.shoot(0);
            cannon.shoot(0);
            Console.WriteLine("You have only 1 shot left!");
            cannon.shoot(0);
            Console.WriteLine("~~Enemy defeated!~~");


            Console.Read();






        }
    }
}
