class Program
{
    static async Task Main(string[] args)
    {
        await MethodThatAcceptsDelegate(async () =>
        {
            await Task.Delay(1000);
            Console.WriteLine("tits");
        });
    }

    private static async Task MethodThatAcceptsDelegate(Action method)
    {
        await Task.Delay(1);
        method();
    }
}