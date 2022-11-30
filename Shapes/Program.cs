using Shapes;

//Hexagon hex = new Hexagon("Hex");
//hex.Draw();

//Circle cir = new Circle("Cir");
//cir.Draw();
//Console.ReadLine();

Shape[] shapes = {new Hexagon(), new Circle(), new Hexagon("Hex"), new Circle("CIr")};

foreach(Shape shape in shapes)
{
    shape.Draw();
}

// This calls the Draw() method of the ThreeDCircle.
ThreeDCircle ThreeD = new ThreeDCircle();
ThreeD.Draw();
// This calls the Draw() method of the parent!
((Circle)ThreeD).Draw();
Console.ReadLine();