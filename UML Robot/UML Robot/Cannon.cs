using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Robot
{
    class Cannon : Weapons
    {

        public Cannon(float ammo)
        {
            this.ammo = ammo;
        }
        public int shoot(int dmg)
        {
            Console.WriteLine("Robot fires the Cannon...");
            Console.WriteLine("              --------~~~");
            Console.WriteLine("POW!!! ---------~~~~~~~~~~(*)");
            Console.WriteLine("              --------~~~");
            ammo--;
            dmg = +3;
            Console.WriteLine("You have {0} ammo left", ammo);
            Console.WriteLine("You did {0} amount of dmg", dmg);
            return dmg;
        }
    }
}
