using EmployeeApp;

//Manager Sam = new Manager("Sam", 42, 7492, 100000, "333-23-2322", 9000);
//Sam.GiveBonus(300);
//Sam.DisplayStats();
//Console.WriteLine();


//SalesPerson Jack = new SalesPerson("Jack", 35, 9231, 3000, "932-32-3232",  31);
//Jack.GiveBonus(200);
//Jack.DisplayStats();
//Console.ReadLine();


//object frank = new Manager("Frankie", 9, 3000, 40000, "111-11-1111", 5);
//GivePromotion((Manager)frank);

//static void GivePromotion(Employee emp)
//{
//    // Increase pay...
//    // Give new parking space in company garage...
//    Console.WriteLine("{0} was promoted!", emp.Name);
//}


//object[] things = new object[3];
//things[0] = false;
//things[1] = new Manager("Marty", 28, 65, 65456, "4556", 789);
//things[2] = "Last thing";

//foreach (object item in things)
//{
//    Employee e = item as Employee;
//    if (e == null)
//    {
//        Console.WriteLine("Item is not an Employee");
//    }
//    else
//    {
//        e.DisplayStats();
//    }
//}


//static void GivePromotion(Employee emp)
//{
//    if (emp is SalesPerson s)
//    {
//        Console.WriteLine("{0} made {1} sale(s)!", s.Name, s.SalesNumber);
//        Console.WriteLine();
//    }
//    //Check if is Manager, if it is, assign to variable m
//    else if (emp is Manager m)
//    {
//        Console.WriteLine("{0} had {1} stock options...", m.Name, m.StockOptions);
//        Console.WriteLine();
//    }
//    else if (emp is var _)
//    {
//        Console.WriteLine("Unable to promote {0}. Wrong employee type", emp.Name);
//        Console.WriteLine();
//    }
//}
//OR
static void GivePromotion(Employee emp)
{
    Console.WriteLine("{0} was promoted!", emp.Name);
    switch (emp)
    {
        case SalesPerson s when s.SalesNumber > 5:
            Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
            break;
        case Manager m:
            Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
            break;
        case Employee _:
            Console.WriteLine("Unable to promote {0}. Wrong employee type", emp.Name);
            break;
    }
    Console.WriteLine();
}