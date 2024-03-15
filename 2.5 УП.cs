using System;

class Message
{
    private string Text {get; set;}
    private DateTime Time {get; set;}

    public Message(string text, DateTime time)
    { 
       Text = text;
       Time = time;
    }
  
    public Message()
    {
       Text = "Hello world";
       Time = DateTime.Now;
    }

    
    ~Message()
    {
      Console.WriteLine("Destructor called");
    }

    public void DisplayProperties()
    {
        Console.WriteLine(Time.ToString("hh-mm-ss") + ": " + Text);
    }
}

class Program
{
    public static void Main(string[] args)
    {
      
        Message m1 = new Message("Привет", DateTime.Now);
        m1.DisplayProperties();

        Message m2 = new Message();
        m2.DisplayProperties();
    }
}