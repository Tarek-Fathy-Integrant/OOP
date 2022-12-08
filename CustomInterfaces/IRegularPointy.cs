using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces;
interface IRegularPointy : IPointy
{
    //Properties
    int SideLength { get; set; }
    int NumberOfSides { get; }
    int Perimeter => SideLength * NumberOfSides;
    //Static Members
    static string ExampleProperty { get; set; }
    static IRegularPointy() => ExampleProperty = "Foo";
}
