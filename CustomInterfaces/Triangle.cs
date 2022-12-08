﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }
        
        public byte Points => 3;
    }
}
