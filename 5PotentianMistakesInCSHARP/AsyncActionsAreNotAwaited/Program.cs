class Program
{
    static async Task Main(string[] args)
    {
        await MethodThatAcceptsDelegateAndCanBeAwaited(async () =>
        {
            await Task.Delay(1000);
            Console.WriteLine("tits");
        });
    }

    private static async Task MethodThatAcceptsDelegateAndCannotBeAwaited(Action method)
    {
        await Task.Delay(1);
        method();
    }

    private static async Task MethodThatAcceptsDelegateAndCanBeAwaited(Func<Task> method)
    {
        await Task.Delay(1);
        await method();
    }
}