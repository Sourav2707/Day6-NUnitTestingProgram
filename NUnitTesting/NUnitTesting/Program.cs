using NUnitTesting;
Console.WriteLine("Welcome to NUnit Testing program");
Console.WriteLine("Enter your choice : 1- Celsius to fahrenheit , 2- fahrenheit to Celsius");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice != 1 && choice != 2)
{
    Console.WriteLine("Wrong input");
}
else
{
    Console.WriteLine("Enter the value you want to convert");
    double convert = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Converted value is = {NUnit.Test(choice, convert)}");
}