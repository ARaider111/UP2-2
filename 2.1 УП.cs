using System;

class Student
{
  int[] grade = new int[5];

  public string Surname {get; set;}
  public DateTime DateOfBirth {get; set;}
  public int NumberGroupe {get; set;}
  public int[] Grades {get {return grade;} set {grade = value;}}
  
}

class Program 
{
  static void ClassEntry(Student student)
  {
    Console.WriteLine("Введите фамилию студента: ");
    student.Surname = Console.ReadLine();

    Console.WriteLine("Введите дату рождения студента (дд-мм-гггг): ");
    student.DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

    Console.WriteLine("Введите номер группы: ");
    student.NumberGroupe = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите оценки студента: ");
    for (int i = 0; i < 5; ++i)
    {
      Console.WriteLine($"Оценка №{i + 1}: ");
      student.Grades[i] = int.Parse(Console.ReadLine());
    }
  }
  
  public static void Main (string[] args)
  {
    Student student = new Student();
    ClassEntry(student);

    Console.WriteLine("");
    Console.WriteLine($"Фамилия студента: {student.Surname}");
    Console.WriteLine($"\nДата рождения студента: {student.DateOfBirth.ToString("dd-MM-yyyy")}");
    Console.WriteLine($"\nНомер группы: {student.NumberGroupe}");

    Console.WriteLine("Оценки студента: ");
    for (int i = 0; i < 5; ++i)
    {
      Console.Write($"{student.Grades[i]} ");
    }
  }
}