using BenchmarkDotNet.Attributes;

namespace EmptyArray;

[MemoryDiagnoser]
public class EmptyArrayBenchmark
{
    [Benchmark]
    public int[] NewArray()
    {
        return new int[0];
    }

    [Benchmark]
    public int[] ArrayEmpty()
    {
        return Array.Empty<int>();
    }
}
