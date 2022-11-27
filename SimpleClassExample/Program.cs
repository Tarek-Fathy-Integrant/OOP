using SimpleClassExample;

Console.WriteLine("*****=====OOP=====*****\n\n");

//Car myCar = new Car();
//myCar.PetName = "Pet";
//myCar.Speed = 10;

//for(int i = 0; i < 10; i++)
//{
//    myCar.SpeedUp(i);
//    myCar.printState();
//}
//Console.WriteLine("\n\n\n");

//Car daisy = new Car("Daisy", 75);
//daisy.printState();
//Console.WriteLine("\n\n\n");

Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine("Rider name is {0}", c.driverName);
Console.ReadLine();

Console.ReadLine();