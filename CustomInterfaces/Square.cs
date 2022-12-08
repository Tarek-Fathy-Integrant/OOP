using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces;
internal class Square : Shape, IRegularPointy
{
    //Properties
    public byte Points => 4;
    public int SideLength { get; set; }
    public int NumberOfSides { get; } = 4;
    //Constructors
    public Square() { }
    public Square(string name) : base(name) { }
    //Methods
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}
