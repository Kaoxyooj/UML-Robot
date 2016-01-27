using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Robot
{
    class Gatling : Weapons
    {
        public Gatling(float ammo)
        {
            this.ammo = ammo;
        }

        public int shoot(int dmg)
        {
            ammo -= 10;
            dmg += 1;
            Console.WriteLine("Robot uses the Gatling Gun...");
            Console.WriteLine("THRAT TAT TAT  -   -   -  ::::::::::");
            Console.WriteLine("Robot does {0} dmg and has {1} gatling ammo left.", dmg, ammo);
            return dmg;
        }

    }
}
