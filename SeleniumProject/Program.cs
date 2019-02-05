using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using SeleniumProject.Tests.Signup;

namespace SeleniumProject
{
    class Program
    {
        public static void Main()
        {
            // Create a Test Runner
            TestRunner runner = new TestRunner();

            // Create a new WebDriver
            IWebDriver driver = new ChromeDriver( new ChromeOptions { PageLoadStrategy = PageLoadStrategy.Normal } );

            // Add some tests
            runner.AddTest(new HomeButtonTest(driver));

            // Run the tests
            runner.RunTests();

            // Report the results
            Console.WriteLine("# Tests Passed:  " + runner.TestsPassed);
            Console.WriteLine("# Tests Failed:  " + runner.TestsFailed);
            Console.WriteLine("# Tests Warning: " + runner.TestsWarning);

            // Close the driver
            driver.Close();
        }
    }
}
