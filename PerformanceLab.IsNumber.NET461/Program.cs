using System;
using System.Diagnostics;
using System.Linq;

namespace PerformanceLab.IsNumber.NET461
{
    class Program
    {
        private static TestResult IntParseResult = new TestResult(nameof(IsNumbnerTestMethods.IntParse));
        private static TestResult IntTryParseResult = new TestResult(nameof(IsNumbnerTestMethods.IntTryParse));
        private static TestResult CustomResult = new TestResult(nameof(IsNumbnerTestMethods.Custom));

        static void Main(string[] args)
        {
            const int numberOfIterations = 5000000;

            Console.WriteLine($"Performance Lab. The faster way to check if string is Number");
            Console.WriteLine($"Number of iterations {numberOfIterations}");
            Console.WriteLine($"Start tests...");

            TestValidString(numberOfIterations);
            TestInvalidString(numberOfIterations);
            TestMixedString(numberOfIterations);

            Console.WriteLine($"Tests ended. Summary:");
            Console.WriteLine();

            var results = new[] { IntParseResult, IntTryParseResult, CustomResult }.OrderBy(x => x.GetTotal()).ToArray();

            for (int i = 0; i < results.Length; i++)
            {
                DisplaySummary(i + 1, results[i]);
            }

            Console.WriteLine();
            DisplayDetails(IntParseResult);
            DisplayDetails(IntTryParseResult);
            DisplayDetails(CustomResult);

            Console.ReadKey();
        }

        private static void DisplaySummary(int rank, TestResult testResult)
        {
            Console.WriteLine($"{rank}. {testResult.TestMethodName}: {testResult.GetTotal()}ms");
        }

        private static void DisplayDetails(TestResult testResult)
        {
            Console.WriteLine($"{testResult.TestMethodName} - Total: {testResult.GetTotal()}ms Avg: {testResult.GetAvg()}ms");

            foreach (var result in testResult.Results)
            {
                Console.WriteLine($"{result.Item1}: {result.Item2}ms");
            }

            Console.WriteLine();
        }

        private static void TestValidString(int numberOfIterations)
        {
            Console.WriteLine("1/3 - Testing valid strings...");
            IntParseResult.AddResult(nameof(StringTestData.ValidStrings), TestMethod(nameof(IsNumbnerTestMethods.IntParse), IsNumbnerTestMethods.IntParse, StringTestData.ValidStrings, numberOfIterations));
            IntTryParseResult.AddResult(nameof(StringTestData.ValidStrings), TestMethod(nameof(IsNumbnerTestMethods.IntTryParse), IsNumbnerTestMethods.IntTryParse, StringTestData.ValidStrings, numberOfIterations));
            CustomResult.AddResult(nameof(StringTestData.ValidStrings), TestMethod(nameof(IsNumbnerTestMethods.Custom), IsNumbnerTestMethods.Custom, StringTestData.ValidStrings, numberOfIterations));
        }

        private static void TestInvalidString(int numberOfIterations)
        {
            Console.WriteLine("2/3 - Testing invalid strings...");
            IntParseResult.AddResult(nameof(StringTestData.InvalidStrings), TestMethod(nameof(IsNumbnerTestMethods.IntParse), IsNumbnerTestMethods.IntParse, StringTestData.InvalidStrings, numberOfIterations));
            IntTryParseResult.AddResult(nameof(StringTestData.InvalidStrings), TestMethod(nameof(IsNumbnerTestMethods.IntTryParse), IsNumbnerTestMethods.IntTryParse, StringTestData.InvalidStrings, numberOfIterations));
            CustomResult.AddResult(nameof(StringTestData.InvalidStrings), TestMethod(nameof(IsNumbnerTestMethods.Custom), IsNumbnerTestMethods.Custom, StringTestData.InvalidStrings, numberOfIterations));
        }

        private static void TestMixedString(int numberOfIterations)
        {
            Console.WriteLine("3/3 - Testing mixed strings...");
            IntParseResult.AddResult(nameof(StringTestData.MixedStrings), TestMethod(nameof(IsNumbnerTestMethods.IntParse), IsNumbnerTestMethods.IntParse, StringTestData.MixedStrings, numberOfIterations));
            IntTryParseResult.AddResult(nameof(StringTestData.MixedStrings), TestMethod(nameof(IsNumbnerTestMethods.IntTryParse), IsNumbnerTestMethods.IntTryParse, StringTestData.MixedStrings, numberOfIterations));
            CustomResult.AddResult(nameof(StringTestData.MixedStrings), TestMethod(nameof(IsNumbnerTestMethods.Custom), IsNumbnerTestMethods.Custom, StringTestData.MixedStrings, numberOfIterations));
        }

        private static long TestMethod(string testName, Func<string, bool> methodToTest, string[] testValidStrings, int numberOfIterations)
        {
            Console.Write($"Testing method: {testName}...                                   \r");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numberOfIterations; i++)
            {
                foreach (var numbnerAsString in testValidStrings)
                {
                    var result = methodToTest(numbnerAsString);
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}
