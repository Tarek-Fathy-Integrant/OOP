using ProcessMultipleExceptions;

Console.WriteLine("***** Handling Multiple Exceptions *****\n");
Car myCar = new Car("mc", 10);
try
{
    // Trip Arg out of range exception.
    while (myCar.CurrentSpeed < 150)
    {
        myCar.Accelerate(-10);
        myCar.Accelerate(10);
    }
}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
    //rethrow
    //throw;
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    myCar.CrankTunes(false);
}
Console.ReadLine();