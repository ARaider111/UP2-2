using System;

class Number
{
  int sum = 0;
  public int number1 {get; set;}
  public int number2 {get; set;}

  public void ChangeNumbers()
  {
    Console.WriteLine("Введите 1 число: ");
    this.number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите 2 число: ");
    this.number2 = int.Parse(Console.ReadLine());
     Console.WriteLine("");
  }

  public int SumNumbers()
  {
    sum = number1 + number2;
    return sum;
  }

  public int FindMaxNumber()
  {
    if (number1 > number2)
    {
      return number1;
    }
    else
    {
      return number2;
    }
    
  }
}

class Program
{
  public static void Main (string[] args) 
  {
    Number nums = new Number();
    nums.ChangeNumbers();

    Console.WriteLine($"Число 1: {nums.number1}, Число 2: {nums.number2}");

    Console.WriteLine();
    Console.WriteLine($"Сумма чисел: {nums.SumNumbers()}");

    Console.WriteLine();
    Console.WriteLine($"Максимальное число: {nums.FindMaxNumber()}");
  }
}          