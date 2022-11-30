using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        //Constructors
        public Circle() { }
        public Circle(string name) : base(name) { }
        //Methods
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Circle");

        }
    }
}
