using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class Triangle : Shape, IPointy
    {
        //Properties
        public byte Points => 3;
        //Constructors
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        //Methods
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }
        
        
    }
}
