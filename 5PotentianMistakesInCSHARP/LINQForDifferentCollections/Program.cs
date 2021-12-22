using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using static Program;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Bench>();
    }

    public class ToTest
    {
        public List<Guid> List { get; } = new List<Guid>
        (
            Enumerable.Range(0, 10000).Select(x => Guid.NewGuid())
        );
    }
}

public class Bench
{
    private static readonly ToTest totest = new();

    [Benchmark]
    public bool TestAny() => totest.List.Any();

    [Benchmark]
    public bool TestCount() => totest.List.Count > 0;
}