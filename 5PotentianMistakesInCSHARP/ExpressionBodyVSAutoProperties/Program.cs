using System.Collections.Concurrent;

class Program
{
    static readonly ConcurrentDictionary<string, string> Dictionary = new();

    static async Task Main(string[] args)
    {
        var firstTask = Task.Run(() => AddAndPrint("First call"));
        var secondTask = Task.Run(() => AddAndPrint("Second call"));

        await Task.WhenAll(firstTask, secondTask);

        AddAndPrint("Third call!");
    }

    private static void AddAndPrint(string callText)
    {
        var callValue = Dictionary.GetOrAdd("SomeKey", x =>
        {
            return callText;
        });

        Console.WriteLine(callValue);
    }
}