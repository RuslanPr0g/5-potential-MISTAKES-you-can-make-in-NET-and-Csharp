using System.Collections.Concurrent;

class Program
{
    private static int _visitorCount = 0;
    static readonly ConcurrentDictionary<string, string> Dictionary = new();

    static async Task Main(string[] args)
    {
        var firstTask = Task.Run(() => AddAndPrint("First call"));
        var secondTask = Task.Run(() => AddAndPrint("Second call"));

        await Task.WhenAll(firstTask, secondTask);

        AddAndPrint("Third call!");
        Console.WriteLine($"Called: {_visitorCount} times!");
    }

    private static void AddAndPrint(string callText)
    {
        var callValue = Dictionary.GetOrAdd("SomeKey", x =>
        {
            Interlocked.Increment(ref _visitorCount); // increant threasd-safely
            return callText;
        });

        Console.WriteLine(callValue);
    }
}