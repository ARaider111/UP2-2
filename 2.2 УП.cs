using System;

class Train
{
  public string Destination {get; set;}
  public int TrainNumber {get; set;}
  public DateTime DepartureTime {get; set;}

  public Train(string destination, int trainNumber, DateTime departureTime)
  {
      this.Destination = destination;
      this.TrainNumber = trainNumber;
      this.DepartureTime = departureTime;
  }
}

class Program 
{
  static void OutputInformationPaths(Train  train, Train[] trains)
  {
    Console.WriteLine($"Поезд номер {train.TrainNumber} отправляется в пункт назначения {train.Destination} в {train.DepartureTime.ToString("HH:mm dddd MMMM yyyy")}");
  }
  
  public static void Main (string[] args) 
  {
    Train[] trains = new Train[3]; 
    trains[0] = new Train("Москва", 12, new DateTime(2024, 05, 11, 12, 30, 00));
    trains[1] = new Train("Новосибирск", 23, new DateTime(2024, 04, 21, 10, 00, 00));
    trains[2] = new Train("Томск", 34, new DateTime(2024, 03, 15, 9, 15, 00));

    foreach (Train train in trains)
    {
      OutputInformationPaths(train, trains);
      Console.WriteLine("");
    }

    Console.WriteLine("Введите номер поезда: ");
    int currentNumber = int.Parse(Console.ReadLine());
    foreach (Train train in trains)
    {
      if (train.TrainNumber == currentNumber)
      {
        OutputInformationPaths(train, trains);
        return;
      }
    }

    Console.WriteLine("С таким номером поезда нет");
  }
}