using BenchmarkDotNet.Running;
using ValueTaskVsTask;

BenchmarkRunner.Run<ValueTaskVsTaskBenchmark>();

Console.ReadKey();