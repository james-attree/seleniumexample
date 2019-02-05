using System.Collections.Generic;
using SeleniumProject.Tests;

namespace SeleniumProject
{
    public class TestRunner
    {
        protected List<ITest> Tests { get; set; }
        public int TestsPassed { get; protected set; }
        public int TestsFailed { get; protected set; }
        public int TestsWarning { get; protected set; }

        public TestRunner()
        {
            Tests = new List<ITest>();
            TestsPassed = 0;
            TestsFailed = 0;
            TestsWarning = 0;
        }

        public void AddTest(ITest test)
        {
            Tests.Add(test);
        }

        public void RunTests()
        {
            Tests.ForEach((test) =>
            {
                test.SetUp();
                test.Run();
                test.Shutdown();

                switch (test.Result)
                {
                    case ETestResult.Passed:
                        TestsPassed++;
                        break;
                    case ETestResult.Failed:
                        TestsFailed++;
                        break;
                    case ETestResult.Warning:
                        TestsWarning++;
                        break;
                    default:
                        break;
                }
            });
        }
    }
}
