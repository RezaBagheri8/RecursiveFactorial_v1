
using RecursiveFactorialMethod;

Console.WriteLine("Please enter the number : ");

var userInput = Console.ReadLine();

var factorial = new Factorial();

var result = factorial.Calculate(int.Parse(userInput));

Console.WriteLine(result);
