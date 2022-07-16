using NUnitTesting;
Console.WriteLine("Welcome to NUnit Testing program");
Console.WriteLine("Available notes are 1000, 500, 100, 50, 10, 5, 2, 1");
Console.WriteLine("Enter the amount to be withdrawn");
int n = Convert.ToInt32(Console.ReadLine());
NUnit.Test(n);