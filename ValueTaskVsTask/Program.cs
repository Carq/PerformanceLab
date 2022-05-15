using BenchmarkDotNet.Running;
using SealedClasses;

BenchmarkRunner.Run<ValueTaskVsTaskBenchmark>();

Console.ReadKey();