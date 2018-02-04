using System;
class calculator
{
  static void Main()
  {
    Console.WriteLine("Welcome to my Calculator!");
    Console.WriteLine("Input first number.");
    string stringfirstNumber = Console.ReadLine();
    int firstNumber = int.Parse(stringfirstNumber);

    Console.WriteLine("Input second number.");
    string stringsecondNumber = Console.ReadLine();
    int secondNumber = int.Parse(stringsecondNumber);

    int addtotal = firstNumber + secondNumber;

    Console.WriteLine("Here is the total:  " + addtotal);
  }
}
