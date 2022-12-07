using CustomException;

Car myCar = new Car("mc", 90);
try
{
    // Trip exception.
    myCar.Accelerate(50);
}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ErrorTimeStamp);
    Console.WriteLine(e.CauseOfError);
}
Console.ReadLine();