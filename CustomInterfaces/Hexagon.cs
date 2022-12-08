
namespace CustomInterfaces
{
    internal class Hexagon : Shape, IPointy, IDraw3D
    {
        //Properties
        public byte Points => 6;
        //Constructors
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        //Methods
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
        }
        public void Draw3D() => Console.WriteLine("Drawing Hexagon in 3D!");
    }
}
