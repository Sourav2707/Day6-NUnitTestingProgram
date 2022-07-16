using NUnitTesting;
Console.WriteLine("Welcome to NUnit Testing program");
Console.WriteLine("Enter the principle amount");
double P = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter for how many years");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the rate to be compounded monthly");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Payment to be made monthly is = {NUnit.Test(P,y,r)}");