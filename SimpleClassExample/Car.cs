using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public string PetName;
        public int Speed;

        public void printState() => Console.WriteLine($"{PetName} is going @ {Speed} MPH");
        public void SpeedUp(int delta) => Speed += delta;

        public Car()
        {
            PetName = "Pet?";
            Speed = 0;
        }
        public Car(string petName) => PetName = petName;
        public Car(string petName, int speed)
        {
            PetName = petName;
            Speed = speed;
        }
        public Car(string petName, int speed, out bool inDanger)
        {
            PetName = petName;
            Speed = speed;

            if(speed > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }
    }
}
