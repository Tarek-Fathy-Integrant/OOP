﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class ThreeDCircle : Circle, , IDraw3D
    {
        public new string PetName { get; set; }
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Cirlce");
        }
        public void Draw3D() => Console.WriteLine("Drawing Circle in 3D!");
    }
}
