using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await DoWorkAsync();
        Console.WriteLine("Finished");
    }

    static async Task DoWorkAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("Work complete");
    }
}
