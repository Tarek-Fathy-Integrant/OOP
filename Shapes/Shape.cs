using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal abstract class Shape
    {
        //Properties
        public string PetName { get; set; }
        //Constructors
        protected Shape(string name = "NoName")
        {
            PetName = name;
        }
        //Methods
        public abstract void Draw();
    }
}
