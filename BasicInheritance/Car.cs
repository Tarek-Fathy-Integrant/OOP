using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    internal class Car
    {
        //Fields
        public readonly int MaxSpeed;
        private int _currSpeed;
        //Properties
        public int Speed
        {
            get { return _currSpeed; }
            set
            {
                _currSpeed = value;
                if(_currSpeed > MaxSpeed)
                {
                    _currSpeed = MaxSpeed;
                }
            }
        }
        //Constructors
        public Car() : this(55) { }
        public Car(int max)
        {
            MaxSpeed = max;
        }
        //Methods
    }
}
