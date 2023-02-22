using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vuClass
{
    internal class Car
    {
        int baseSpeed;

        public Car(int baseSpeed)
        {
            this.baseSpeed = baseSpeed;
        }

        public void increseSpeed()
        {
            baseSpeed += 10;
        }
        public void decreseSpeed()
        {
            baseSpeed -= 10;
            if (baseSpeed < 0)
            {
                baseSpeed = 0;
            }
        }
        public void printSpeed()
        {
            Console.WriteLine("Current speed: " + baseSpeed);
        }
    }
}
