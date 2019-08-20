using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PerformanceLab.IsEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfIterations = int.MaxValue; ;

            Console.WriteLine($"Performance Lab. The faster way to check if string is collection is empty");
            Console.WriteLine($"Number of iterations {numberOfIterations}");
            Console.WriteLine($"Start tests...");

            var collection5000 = Enumerable.Range(0, 20000).Select(x => x.ToString() + "lorem ipsum").ToList();

            var result = TestMethod("Count", CountTestMethod, collection5000, numberOfIterations);
            Console.WriteLine($"Count: {result}ms");

            result = TestMethod("Any", CountTestMethod, collection5000, numberOfIterations);
            Console.WriteLine($"Any: {result}ms");

            Console.ReadKey();
        }

        private static long TestMethod(string testName, Func<IList<string>, bool> methodToTest, IList<string> collectionToTest, int numberOfIterations)
        {
            Console.Write($"Testing method: {testName}...                                   \r");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < numberOfIterations; i++)
            {
                var result = methodToTest(collectionToTest);
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static bool CountTestMethod(IList<string> collectionToTest)
        {
            return collectionToTest.Count == 0;
        }

        private static bool AnyTestMethod(IList<string> collectionToTest)
        {
            return !collectionToTest.Any();
        }
    }
}
