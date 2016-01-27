using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Robot
{
    public class SlowWingsBody : Body
    {
        public new void fly()
        {                   
            Console.WriteLine("Robot starts to fly using the Slow Wings");
        }
    }
}