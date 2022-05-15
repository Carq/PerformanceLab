using BenchmarkDotNet.Running;
using SealedClasses;

BenchmarkRunner.Run<SealedBenchmark>();
BenchmarkRunner.Run<SealedCastBenchmark>();

Console.ReadKey();