using RecordInheritance;

PositionalCar pc = new PositionalCar("Honda", "Pilot", "Blue");
PositionalMinivan pm = new PositionalMinivan("Honda", "Pilot", "Blue", 10);
Console.WriteLine($"Checking PositionalMiniVan is-a PositionalCar:{pm is PositionalCar}");

