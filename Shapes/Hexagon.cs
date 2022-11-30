
namespace Shapes
{
    internal class Hexagon : Shape
    {
        //Constructors
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        //Methods
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
        }
    }
}
