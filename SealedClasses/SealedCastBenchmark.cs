using BenchmarkDotNet.Attributes;
using SealedClasses.ClassesToTest;

namespace SealedClasses;

public class SealedCastBenchmark
{
    BaseClass baseClass = new();

    [Benchmark]
    public bool SealedClass()
    {
        return baseClass is SealedClass;
    }

    [Benchmark]
    public bool NonSealedClass()
    {
        return baseClass is NonSealedClass;
    }
}
