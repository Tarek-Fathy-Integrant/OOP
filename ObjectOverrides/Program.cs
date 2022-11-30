using ObjectOverrides;

//Person p1 = new Person();

//Console.WriteLine("ToString: {0}", p1.ToString());
//Console.WriteLine("Hash code: {0}", p1.GetHashCode());
//Console.WriteLine("Type: {0}", p1.GetType());

//Person p2 = p1;
//object o = p2;
//if (o.Equals(p1) && p2.Equals(o))
//{
//    Console.WriteLine("Same instance!");
//}
//Console.ReadLine();


Person p1 = new Person("Homer", "Simpson", 50, "111-11-1111");
Person p2 = new Person("Homer", "Simpson", 50, "111-11-1111");
// Get stringified version of objects.
Console.WriteLine("p1.ToString() = {0}", p1.ToString());
Console.WriteLine("p2.ToString() = {0}", p2.ToString());
// Test overridden Equals().
Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
// Test hash codes.
//still using the hash of the SSN
Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
Console.WriteLine();
// Change age of p2 and test again.
p2.Age = 45;
Console.WriteLine("p1.ToString() = {0}", p1.ToString());
Console.WriteLine("p2.ToString() = {0}", p2.ToString());
Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));
//still using the hash of the SSN
Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
Console.ReadLine();