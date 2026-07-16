using System;

delegate void Notify(string message);

class Program
{
    static void Main()
    {
        Notify target = ShowMessage;
        target("Hello from the delegate!");
    }

    static void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}
