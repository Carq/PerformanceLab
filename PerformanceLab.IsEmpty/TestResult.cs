using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceLab.IsEmpty
{
    public class TestResult
    {
        public TestResult(string testMethodName)
        {
            TestMethodName = testMethodName;
            Results = new List<Tuple<string, long>>();
        }

        public string TestMethodName { get; private set; }

        public List<Tuple<string, long>> Results { get; private set; }

        public void AddResult(string categoryName, long result)
        {
            Results.Add(new Tuple<string, long>(categoryName, result));
        }

        public long GetTotal()
        {
            return Results.Sum(x => x.Item2);
        }

        public double GetAvg()
        {
            return Results.Average(x => x.Item2);
        }

    }
}
