using BenchmarkDotNet.Attributes;
using SealedClasses.ClassesToTest;

namespace SealedClasses;

public class SealedBenchmark
{
    SealedClass sealedClass = new();

    NonSealedClass nonSealedClass = new();

    [Benchmark]
    public int SealedClass()
    {
        return sealedClass.Method() + 1337;
    }

    [Benchmark]
    public int NonSealedClass()
    {
        return nonSealedClass.Method() + 1337;
    }

    [Benchmark]
    public int SealedClassDirectUse()
    {
        SealedClass sealedClass = new();
        return sealedClass.Method() + 1337;
    }

    [Benchmark]
    public int NonSealedClassDirectUse()
    {
        NonSealedClass nonSealedClass = new();
        return nonSealedClass.Method() + 1337;
    }
}
