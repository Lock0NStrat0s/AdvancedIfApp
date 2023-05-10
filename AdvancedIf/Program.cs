
Console.Write("What is your first name: ");
string firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string lastName = Console.ReadLine();

if (firstName.ToLower() == "mohammad" &&
    lastName.ToLower() == "jabir")
{
    Console.WriteLine("Hello Mr. Jabir");
}
else if (firstName.ToLower() == "mohammad")
{
    Console.WriteLine("Hello you have a cool first name.");
}
else if (lastName.ToLower() == "jabir")
{
    Console.WriteLine("Last name be rad.");
}
else
{
    Console.WriteLine("Sorry you don't have a cooler name.");
}

// ==, >, >=, <, <=, !=
int age = 43;

if ((age >= 40 && age < 50) || (age >= 70 && age < 80))
{
    Console.WriteLine("You are in your 40's or 70's");
}
