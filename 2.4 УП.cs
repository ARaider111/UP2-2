using System;

class Count 
{
  public int count {get; set;}

  public void IncreaseCounter()
  {
    ++count;
  }

  public void ReduceCounter()
  {
    --count;
  }
}

class Program
{
  public static void Main (string[] args)
  {
    int temp = 0;
    Count count = new Count();
    count.count = 0;
    Random random = new Random();
    do
    {
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Текущее значение счетчика: " + count.count);
      Console.WriteLine("-------------------------------------");
      
      Console.WriteLine ("Выберете действие: ");
      Console.WriteLine("1 - Установить значение по умолчанию;");
      Console.WriteLine("2 - Установить произвольное значение;");
      Console.WriteLine("3 - Увеличить счетчик на 1;");
      Console.WriteLine("4 - Уменьшить счетчик на 1;");
      Console.WriteLine("0 - Выход.");
      
      temp = int.Parse(Console.ReadLine());
      switch (temp)
      {
      case 1:
          count.count = 0;
          break;
      case 2:
          count.count = random.Next(0, 10);
          break;
      case 3:
         count.IncreaseCounter();
         break;
      case 4:
         count.ReduceCounter();
         break;
      case 0:
         return;
      default:
          Console.WriteLine("Неверный ввод");
          break;
      }
    } while(temp != 0);
    
    
  }
}