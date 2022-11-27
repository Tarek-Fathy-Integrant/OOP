using RecordsDemo;

Car mycar = new Car { Make = "Honda", Model = "Pilot", Color = "Blue"};
CarRecord AnotherCar = new CarRecord("Honda", "Pilot", "Blue");

Console.WriteLine(mycar.DisplayCarDetails());
Console.WriteLine(AnotherCar.ToString());