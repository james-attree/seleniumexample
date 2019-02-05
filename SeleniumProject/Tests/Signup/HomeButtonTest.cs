using System;
using OpenQA.Selenium;

namespace SeleniumProject.Tests.Signup
{
    class HomeButtonTest : ITest
    {
        public ETestResult Result { get; protected set; }
        public IWebDriver Driver { get; protected set; }

        public HomeButtonTest(IWebDriver driver)
        {
            Driver = driver;
            Result = ETestResult.Failed;
        }

        public void Run()
        {
            try
            {
                // Get the Home Button element
                IWebElement homeButton = Driver.FindElement(By.Id("bb_home"));

                // Check that it has the correct text
                if(homeButton.Text == "Home")
                {
                    // If so, make this test pass
                    Result = ETestResult.Passed;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in test: " + e.Message);
            }
        }

        public void SetUp()
        {
            Driver.Url = "https://widgitonline.com";
        }

        public void Shutdown()
        {
            // No need for a shutdown
        }
    }
}
